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
    public class DoAns1Controller : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/DoAns1
        public ActionResult Index()
        {
            var doAns = db.DoAns.Include(d => d.LoaiDoAn).Include(d => d.SanPham).Include(d => d.ThongTinDoAn);
            return View(doAns.ToList());
        }

        // GET: Admin/DoAns1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoAn doAn = db.DoAns.Find(id);
            if (doAn == null)
            {
                return HttpNotFound();
            }
            return View(doAn);
        }

        // GET: Admin/DoAns1/Create
        public ActionResult Create()
        {
            ViewBag.maLoaiDoAn = new SelectList(db.LoaiDoAns, "maLoaiDoAn", "tenLoaiDoAn");
            ViewBag.maDoAn = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham");
            ViewBag.maDoAn = new SelectList(db.ThongTinDoAns, "maDoAn", "donViBan");
            return View();
        }

        // POST: Admin/DoAns1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maDoAn,maLoaiDoAn,tenDoAn,HinhURL")] DoAn doAn)
        {
            if (ModelState.IsValid)
            {
                db.DoAns.Add(doAn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maLoaiDoAn = new SelectList(db.LoaiDoAns, "maLoaiDoAn", "tenLoaiDoAn", doAn.maLoaiDoAn);
            ViewBag.maDoAn = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham", doAn.maDoAn);
            ViewBag.maDoAn = new SelectList(db.ThongTinDoAns, "maDoAn", "donViBan", doAn.maDoAn);
            return View(doAn);
        }

        // GET: Admin/DoAns1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoAn doAn = db.DoAns.Find(id);
            if (doAn == null)
            {
                return HttpNotFound();
            }
            ViewBag.maLoaiDoAn = new SelectList(db.LoaiDoAns, "maLoaiDoAn", "tenLoaiDoAn", doAn.maLoaiDoAn);
            ViewBag.maDoAn = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham", doAn.maDoAn);
            ViewBag.maDoAn = new SelectList(db.ThongTinDoAns, "maDoAn", "donViBan", doAn.maDoAn);
            return View(doAn);
        }

        // POST: Admin/DoAns1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maDoAn,maLoaiDoAn,tenDoAn,HinhURL")] DoAn doAn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doAn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maLoaiDoAn = new SelectList(db.LoaiDoAns, "maLoaiDoAn", "tenLoaiDoAn", doAn.maLoaiDoAn);
            ViewBag.maDoAn = new SelectList(db.SanPhams, "maSanPham", "maLoaiSanPham", doAn.maDoAn);
            ViewBag.maDoAn = new SelectList(db.ThongTinDoAns, "maDoAn", "donViBan", doAn.maDoAn);
            return View(doAn);
        }

        // GET: Admin/DoAns1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoAn doAn = db.DoAns.Find(id);
            if (doAn == null)
            {
                return HttpNotFound();
            }
            return View(doAn);
        }

        // POST: Admin/DoAns1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DoAn doAn = db.DoAns.Find(id);
            db.DoAns.Remove(doAn);
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
