using Microsoft.AspNet.Identity.Owin;
using System.Web.Mvc;
using VEB.Models;
using BCrypt.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using System.Linq;

namespace VEB.Controllers
{
    public class LoginController : Controller
    {

        private DBQLCHTAN db = new DBQLCHTAN();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserLoginModel user)
        {
            var userInDb = db.TaiKhoanNhanViens.Where(u => u.tenTaiKhoan == user.tenDangNhap && u.matKhau == user.matKhau).FirstOrDefault();
            if(userInDb!=null)
            {
                FormsAuthentication.SetAuthCookie(user.tenDangNhap, false);
                return RedirectToAction("Index", "Home");
            }else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            return View();
        }
    }
}