using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQLCHTAN.Models;

namespace WebQLCHTAN.Controllers
{
    public class QuanLyController : Controller
    {
        QLCUAHANGTHUCANNHANH db = new QLCUAHANGTHUCANNHANH();
        // GET: QuanLy
        public ActionResult TrangQuanLy()
        {
            return View();
        }
    }
}