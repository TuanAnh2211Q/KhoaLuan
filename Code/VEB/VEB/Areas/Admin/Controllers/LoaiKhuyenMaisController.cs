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
    public class LoaiKhuyenMaisController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/LoaiKhuyenMais
        public ActionResult Index()
        {
            return View(db.LoaiKhuyenMais.ToList());
        }

        // GET: Admin/LoaiKhuyenMais/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiKhuyenMai loaiKhuyenMai = db.LoaiKhuyenMais.Find(id);
            if (loaiKhuyenMai == null)
            {
                return HttpNotFound();
            }
            return View(loaiKhuyenMai);
        }

        // GET: Admin/LoaiKhuyenMais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiKhuyenMais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maLoaiKhuyenMai,tenLoaiKhuyenMai")] LoaiKhuyenMai loaiKhuyenMai)
        {
            if (ModelState.IsValid)
            {
                db.LoaiKhuyenMais.Add(loaiKhuyenMai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiKhuyenMai);
        }

        // GET: Admin/LoaiKhuyenMais/Edit/5
        public ActionResult Edit(string maLoaiKhuyenMai)
        {
            if (maLoaiKhuyenMai == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiKhuyenMai loaiKhuyenMai = db.LoaiKhuyenMais.Find(maLoaiKhuyenMai);
            if (loaiKhuyenMai == null)
            {
                return HttpNotFound();
            }
            return View(loaiKhuyenMai);
        }

        // POST: Admin/LoaiKhuyenMais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maLoaiKhuyenMai,tenLoaiKhuyenMai")] LoaiKhuyenMai loaiKhuyenMai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiKhuyenMai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiKhuyenMai);
        }

        // GET: Admin/LoaiKhuyenMais/Delete/5
        public ActionResult Delete(string maLoaiKhuyenMai)
        {
            if (maLoaiKhuyenMai == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiKhuyenMai loaiKhuyenMai = db.LoaiKhuyenMais.Find(maLoaiKhuyenMai);
            if (loaiKhuyenMai == null)
            {
                return HttpNotFound();
            }
            return View(loaiKhuyenMai);
        }

        // POST: Admin/LoaiKhuyenMais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string maLoaiKhuyenMai)
        {
            LoaiKhuyenMai loaiKhuyenMai = db.LoaiKhuyenMais.Find(maLoaiKhuyenMai);
            db.LoaiKhuyenMais.Remove(loaiKhuyenMai);
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
