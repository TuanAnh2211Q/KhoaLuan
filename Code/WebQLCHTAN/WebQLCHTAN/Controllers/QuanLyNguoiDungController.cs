using System.Web.Mvc;
using WebQLCHTAN.Models;
using System.Data.EntityClient;


namespace WebQLCHTAN.Controllers
{
    public class QuanLyNguoiDungController : Controller
    {
        QLCUAHANGTHUCANNHANH db = new QLCUAHANGTHUCANNHANH();
        // GET: QuanLyNguoiDung
        public ActionResult DanhSachNguoiDung(int? page)
        {
            int pageNum = page ?? 1;
            int pageSize = 5;
            var lstUser = db.KhachHangs.SqlQuery("select_KhachHanng");
            return View(lstUser/*.(x => x.SDT).ToPagedList(pageNum, pageSize)*/);
        }
    }
}