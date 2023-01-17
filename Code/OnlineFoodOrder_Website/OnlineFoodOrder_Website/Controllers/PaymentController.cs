﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineFoodOrder_Website.Models;
using OfficeOpenXml;

namespace OnlineFoodOrder_Website.Controllers
{
    public class PaymentController : Controller
    {
        OnlineFoodOrder_DBEntities7 db = new OnlineFoodOrder_DBEntities7();
        // GET: Payment

        
        public ActionResult PaymentForm()
        {

            User user = Session["User"] as User;
            int userID = user.UserID;
            decimal ToTalOfCart;
            List<CartItem> lstCart = Session["ItemCart"] as List<CartItem>;

            var CartOfUser = lstCart.Where(x => x.UserID == userID);


            ToTalOfCart = (decimal)CartOfUser.Sum(x => x.ItemPriceTotal);

            ViewBag.TotalCart = ToTalOfCart;
            return View();
        }
        public static string RandomChar()
        {
            string randomStr = "";
            try
            {

                string[] myIntArray = new string[5];
                int x;
                Random autoRand = new Random();
                for (x = 0; x < 5; x++)
                {
                    myIntArray[x] = Convert.ToChar(Convert.ToInt32(autoRand.Next(65, 87))).ToString();
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception ex)
            {
                randomStr = "error";
            }
            return randomStr;
        }

        [HttpPost]
        public ActionResult PaymentForm(FormCollection form)
        {
            // Add data into payment
            Payment payment = new Payment();
            if (form["txtCardNumber"] != null || form["txtUserName"] != null)
            {
                payment.PaymentName = form["txtUserName"];
                payment.CardNo = form["txtCardNumber"];
                string day = Convert.ToString(DateTime.Now.Day);
                string month = Convert.ToString(DateTime.Now.Month);
                string year = Convert.ToString(DateTime.Now.Year);
                string expirationDate = day + "/" + month + "/" + year;
                payment.ExpiryDate = expirationDate;
                payment.CvvNo = Convert.ToInt32(form["txtCvv"]);
                payment.Address = form["txtDeliveryAddress"];
                payment.PaymentMode = "CreditCard";
            }
            else
            {
                payment.PaymentName = null;
                payment.CardNo = null;
                payment.ExpiryDate = null;
                payment.CardNo = null;
                payment.Address = form["txtDeliveryAddress"];
                payment.PaymentMode = "Delivery";
            }
            db.Payments.Add(payment);
            db.SaveChanges();

            // Call ListItem of User in ItemCart
            User user = Session["User"] as User;
            int UserID = user.UserID;

            List<CartItem> listCart = Session["ItemCart"] as List<CartItem>;

            var cartOfUser = listCart.Where(x => x.UserID == UserID).ToList();

            var totalItem = cartOfUser.Sum(x => x.Quantity);

            DateTime orderDate = DateTime.Now;
            string orderNo = RandomChar();
            // Add data into Order
            for (int i = 0; i < cartOfUser.Count; i++)
            {
                Order order = new Order();
                order.UserID = UserID;
                order.OrderNo = orderNo;
                order.Quantity = totalItem;
                order.Statuss = "Pending";
                order.PaymentID = payment.PaymentID;
                order.OrderDate = orderDate;
                order.ProductID = cartOfUser[i].ProductID;
                db.Orders.Add(order);
                db.SaveChanges();
            }

            // Create and Save List<OrderInvoice>
            List<OrderInvoice> OrderInvoice = new List<OrderInvoice>();

            List<CartItem> lstCart = Session["ItemCart"] as List<CartItem>;
            var CartOfUser = lstCart.Where(x => x.UserID == UserID).ToList();

            for (int i = 0; i < CartOfUser.Count; i++)
            {
                OrderInvoice orderInvoice = new OrderInvoice();
                orderInvoice.UserID = UserID;
                orderInvoice.OrderNo = orderNo;
                orderInvoice.ProductName = cartOfUser[i].ProductName;
                orderInvoice.ProductID = cartOfUser[i].ProductID;
                orderInvoice.Quantity = cartOfUser[i].Quantity;
                orderInvoice.Price = cartOfUser[i].Price;
                orderInvoice.TotalItemPrice = cartOfUser[i].ItemPriceTotal;
                OrderInvoice.Add(orderInvoice);
            }


            Session["OrderInvoice"] = OrderInvoice;
            Session["ItemCart"] = null;
            return RedirectToAction("OrderInvoice");
        }

        public ActionResult OrderInvoice()
        {
            List<OrderInvoice> orderInvoice = Session["OrderInvoice"] as List<OrderInvoice>;
            ViewBag.TotalCart = orderInvoice.Sum(x => x.TotalItemPrice);
            return View(orderInvoice);
        }

        public ActionResult DownloadInvoice()
        {
            return View();
        }

       
    

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                    db.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}