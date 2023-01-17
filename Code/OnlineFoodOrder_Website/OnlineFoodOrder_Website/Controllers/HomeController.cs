using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineFoodOrder_Website.Models;

namespace OnlineFoodOrder_Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QLCUAHANGTHUCANNHANHEntities12 db = new QLCUAHANGTHUCANNHANHEntities12();
        public ActionResult Index()
        {
            if(Session["HoaDonDatHang"]!=null)
            {
                Session["HoaDonDatHang"] = null;
            }
            ViewBag.SanPham= db.SanPhams.Where()
            return View();
        }
    }
}