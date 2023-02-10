using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VEB.Models;

namespace VEB.Areas.Admin.Controllers
{
    public class NhanViensController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/NhanViens
        public ActionResult Index()
        {
            var nhanViens = db.NhanViens.Include(n => n.ChucDanh).Include(n => n.LoaiNhanVien);
            return View(nhanViens.ToList());
        }

        // GET: Admin/NhanViens/Details/5
        public ActionResult Details(string maNV)
        {
            if (maNV == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(maNV);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }
        private bool kiemTraMaNhanVien(string maNV)
        {
            using (var context = new DBQLCHTAN())
            {
                return context.NhanViens.Any(e => e.maNhanVien == maNV);
            }
        }

        // GET: Admin/NhanViens/Create
        public ActionResult Create()
        {
            ViewBag.maChucDanh = new SelectList(db.ChucDanhs, "maChucDanh", "tenChucDanh");
            ViewBag.maLoaiNhanVien = new SelectList(db.LoaiNhanViens, "maLoaiNhanVien", "tenLoaiNhanVien");
            return View();
        }

        // POST: Admin/NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maNhanVien,tenNhanVien,Phai,SDT,Email,diaChi,maChucDanh,maLoaiNhanVien")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                var nvTonTai = db.NhanViens.SingleOrDefault(e => e.maNhanVien == nhanVien.maNhanVien);
                if(nvTonTai==null)
                {
                    db.NhanViens.Add(nhanVien);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }    
                else
                {
                    ModelState.AddModelError("maNhanVien", "Mã nhân viên đã tồn tại");
                }

            }

            ViewBag.maChucDanh = new SelectList(db.ChucDanhs, "maChucDanh", "tenChucDanh", nhanVien.maChucDanh);
            ViewBag.maLoaiNhanVien = new SelectList(db.LoaiNhanViens, "maLoaiNhanVien", "tenLoaiNhanVien", nhanVien.maLoaiNhanVien);
            return View(nhanVien);
        }

        // GET: Admin/NhanViens/Edit/5
        public ActionResult Edit(string maNV)
        {
            if (maNV == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(maNV);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.maChucDanh = new SelectList(db.ChucDanhs, "maChucDanh", "tenChucDanh", nhanVien.maChucDanh);
            ViewBag.maLoaiNhanVien = new SelectList(db.LoaiNhanViens, "maLoaiNhanVien", "tenLoaiNhanVien", nhanVien.maLoaiNhanVien);
            return View(nhanVien);
        }

        // POST: Admin/NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maNhanVien,tenNhanVien,Phai,SDT,Email,diaChi,maChucDanh,maLoaiNhanVien")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maChucDanh = new SelectList(db.ChucDanhs, "maChucDanh", "tenChucDanh", nhanVien.maChucDanh);
            ViewBag.maLoaiNhanVien = new SelectList(db.LoaiNhanViens, "maLoaiNhanVien", "tenLoaiNhanVien", nhanVien.maLoaiNhanVien);
            return View(nhanVien);
        }

        // GET: Admin/NhanViens/Delete/5
        public ActionResult Delete(string maNV)
        {
            if (maNV == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(maNV);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: Admin/NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string maNV)
        {
            NhanVien nhanVien = db.NhanViens.Find(maNV);
            db.NhanViens.Remove(nhanVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
