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
    public class NuocUongsController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/NuocUongs
        public ActionResult Index()
        {
            var nuocUongs = db.NuocUongs.Include(n => n.MatHang).Include(n => n.SanPham);
            return View(nuocUongs.ToList());
        }

        // GET: Admin/NuocUongs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NuocUong nuocUong = db.NuocUongs.Find(id);
            if (nuocUong == null)
            {
                return HttpNotFound();
            }
            return View(nuocUong);
        }

        // GET: Admin/NuocUongs/Create
        public ActionResult Create()
        {
            ViewBag.maNuoc = new SelectList(db.MatHangs.Where(e => db.SanPhams.FirstOrDefault(s => s.maLoaiSanPham == "MLSP002" && s.maSanPham == e.maHang) != null), "maHang", "tenHang");
            return View();
        }

        // POST: Admin/NuocUongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maNuoc,tenNuoc,donViBan,giaBanNuoc,HinhURL")] NuocUong nuocUong)
        {
            if (ModelState.IsValid)
            {
                db.NuocUongs.Add(nuocUong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maNuoc = new SelectList(db.MatHangs, "maHang", "tenHang", nuocUong.maNuoc);
            ViewBag.maNuoc = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham", nuocUong.maNuoc);
            return View(nuocUong);
        }

        // GET: Admin/NuocUongs/Edit/5
        public ActionResult Edit(string maNuoc)
        {
            if (maNuoc == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NuocUong nuocUong = db.NuocUongs.Find(maNuoc);
            if (nuocUong == null)
            {
                return HttpNotFound();
            }
            ViewBag.maNuoc = new SelectList(db.MatHangs, "maHang", "tenHang", nuocUong.maNuoc);
            ViewBag.maNuoc = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham", nuocUong.maNuoc);
            return View(nuocUong);
        }

        // POST: Admin/NuocUongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maNuoc,tenNuoc,donViBan,giaBanNuoc,HinhURL")] NuocUong nuocUong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nuocUong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maNuoc = new SelectList(db.MatHangs, "maHang", "tenHang", nuocUong.maNuoc);
            ViewBag.maNuoc = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham", nuocUong.maNuoc);
            return View(nuocUong);
        }

        // GET: Admin/NuocUongs/Delete/5
        public ActionResult Delete(string maNuoc)
        {
            if (maNuoc == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NuocUong nuocUong = db.NuocUongs.Find(maNuoc);
            if (nuocUong == null)
            {
                return HttpNotFound();
            }
            return View(nuocUong);
        }

        // POST: Admin/NuocUongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string maNuoc)
        {
            NuocUong nuocUong = db.NuocUongs.Find(maNuoc);
            db.NuocUongs.Remove(nuocUong);
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
