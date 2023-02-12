using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEB.Models;

namespace VEB.Controllers
{
    public class HomeController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult LoadMenu()
        {
            return View();
        }
        public ActionResult Login(KhachHang user)
        {
            var userInDB = db.KhachHangs.Where(u => u.SDT == user.SDT && u.matKhau == user.matKhau).FirstOrDefault();
            if(userInDB!=null)
            {
              
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}