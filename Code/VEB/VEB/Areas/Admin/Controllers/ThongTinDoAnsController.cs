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
    public class ThongTinDoAnsController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/ThongTinDoAns
        public ActionResult Index(string maDoAn)
        {
            var thongTinDoAns = db.ThongTinDoAns.Include(t => t.DoAn).Where(t => t.maDoAn == maDoAn);
            return View(thongTinDoAns.ToList());
        }
        // GET: Admin/ThongTinDoAns/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongTinDoAn thongTinDoAn = db.ThongTinDoAns.Find(id);
            if (thongTinDoAn == null)
            {
                return HttpNotFound();
            }
            return View(thongTinDoAn);
        }

        // GET: Admin/ThongTinDoAns/Create
        public ActionResult Create()
        {
            ViewBag.maDoAn = new SelectList(db.DoAns, "maDoAn", "maLoaiDoAn");
            return View();
        }

        // POST: Admin/ThongTinDoAns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maDoAn,donViBan,donGia,ghiChu")] ThongTinDoAn thongTinDoAn)
        {
            if (ModelState.IsValid)
            {
                db.ThongTinDoAns.Add(thongTinDoAn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maDoAn = new SelectList(db.DoAns, "maDoAn", "maLoaiDoAn", thongTinDoAn.maDoAn);
            return View(thongTinDoAn);
        }

        // GET: Admin/ThongTinDoAns/Edit/5
        public ActionResult Edit(string maDoAn)
        {
            if (maDoAn == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongTinDoAn thongTinDoAn = db.ThongTinDoAns.Find(maDoAn);
            if (thongTinDoAn == null)
            {
                return HttpNotFound();
            }
            ViewBag.maDoAn = new SelectList(db.DoAns, "maDoAn", "maLoaiDoAn", thongTinDoAn.maDoAn);
            return View(thongTinDoAn);
        }

        // POST: Admin/ThongTinDoAns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maDoAn,donViBan,donGia,ghiChu")] ThongTinDoAn thongTinDoAn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thongTinDoAn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","DoAns");
            }
            ViewBag.maDoAn = new SelectList(db.DoAns, "maDoAn", "maLoaiDoAn", thongTinDoAn.maDoAn);
            return View(thongTinDoAn);
        }

        // GET: Admin/ThongTinDoAns/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongTinDoAn thongTinDoAn = db.ThongTinDoAns.Find(id);
            if (thongTinDoAn == null)
            {
                return HttpNotFound();
            }
            return View(thongTinDoAn);
        }

        // POST: Admin/ThongTinDoAns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ThongTinDoAn thongTinDoAn = db.ThongTinDoAns.Find(id);
            db.ThongTinDoAns.Remove(thongTinDoAn);
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
