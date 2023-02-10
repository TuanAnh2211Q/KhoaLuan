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
    public class KhuyenMaisController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/KhuyenMais
        public ActionResult Index()
        {
            var khuyenMais = db.KhuyenMais.Include(k => k.LoaiKhuyenMai);
            return View(khuyenMais.ToList());
        }

        // GET: Admin/KhuyenMais/Details/5
        public ActionResult Details(string maKm)
        {
            if (maKm == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhuyenMai khuyenMai = db.KhuyenMais.Find(maKm);
            if (khuyenMai == null)
            {
                return HttpNotFound();
            }
            return View(khuyenMai);
        }

        // GET: Admin/KhuyenMais/Create
        public ActionResult Create()
        {
            ViewBag.maLoaiKhuyenMai = new SelectList(db.LoaiKhuyenMais, "maLoaiKhuyenMai", "tenLoaiKhuyenMai");
            return View();
        }

        // POST: Admin/KhuyenMais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maKhuyenMai,tenKhuyenMai,maLoaiKhuyenMai,mucGiam")] KhuyenMai khuyenMai)
        {
            if (ModelState.IsValid)
            {
                db.KhuyenMais.Add(khuyenMai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maLoaiKhuyenMai = new SelectList(db.LoaiKhuyenMais, "maLoaiKhuyenMai", "tenLoaiKhuyenMai", khuyenMai.maLoaiKhuyenMai);
            return View(khuyenMai);
        }

        // GET: Admin/KhuyenMais/Edit/5
        public ActionResult Edit(string maKm)
        {
            if (maKm == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhuyenMai khuyenMai = db.KhuyenMais.Find(maKm);
            if (khuyenMai == null)
            {
                return HttpNotFound();
            }
            ViewBag.maLoaiKhuyenMai = new SelectList(db.LoaiKhuyenMais, "maLoaiKhuyenMai", "tenLoaiKhuyenMai", khuyenMai.maLoaiKhuyenMai);
            return View(khuyenMai);
        }

        // POST: Admin/KhuyenMais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maKhuyenMai,tenKhuyenMai,maLoaiKhuyenMai,mucGiam")] KhuyenMai khuyenMai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khuyenMai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maLoaiKhuyenMai = new SelectList(db.LoaiKhuyenMais, "maLoaiKhuyenMai", "tenLoaiKhuyenMai", khuyenMai.maLoaiKhuyenMai);
            return View(khuyenMai);
        }

        // GET: Admin/KhuyenMais/Delete/5
        public ActionResult Delete(string maKm)
        {
            if (maKm == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhuyenMai khuyenMai = db.KhuyenMais.Find(maKm);
            if (khuyenMai == null)
            {
                return HttpNotFound();
            }
            return View(khuyenMai);
        }

        // POST: Admin/KhuyenMais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string maKm)
        {
            KhuyenMai khuyenMai = db.KhuyenMais.Find(maKm);
            db.KhuyenMais.Remove(khuyenMai);
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
