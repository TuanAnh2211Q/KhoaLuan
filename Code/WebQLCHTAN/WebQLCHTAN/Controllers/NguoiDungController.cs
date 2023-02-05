
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQLCHTAN.Models;

namespace WebQLCHTAN.Controllers
{
   
    public class NguoiDungController : Controller
    {
        QLCUAHANGTHUCANNHANH db = new QLCUAHANGTHUCANNHANH();
        // GET: NguoiDung
        public ActionResult HoSoNguoiDung()
        {
            return View();
        }
    }
}