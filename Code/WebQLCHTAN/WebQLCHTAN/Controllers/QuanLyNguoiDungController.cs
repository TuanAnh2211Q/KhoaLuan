using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PagedList;
using WebQLCHTAN.Models;


namespace WebQLCHTAN.Controllers
{
    public class QuanLyNguoiDungController : Controller
    {
        QLCUAHANGTHUCANNHANHEntities1 db = new QLCUAHANGTHUCANNHANHEntities1();
        // GET: QuanLyNguoiDung
        public ActionResult QuanLyNguoiDung()
        {
            return View();
        }
    }
}