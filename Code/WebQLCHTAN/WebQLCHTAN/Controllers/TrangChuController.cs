using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQLCHTAN.Models;

namespace WebQLCHTAN.Controllers
{
    public class TrangChuController : Controller
    {
        QLCUAHANGTHUCANNHANH db = new QLCUAHANGTHUCANNHANH();
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult ThucDon()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult DatBan()
        {
            return View();
        }
        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult DangKi()
        {
            return View();
        }
    }
}