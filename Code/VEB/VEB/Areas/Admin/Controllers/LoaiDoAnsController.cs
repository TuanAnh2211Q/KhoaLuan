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
    public class LoaiDoAnsController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/LoaiDoAns
        public ActionResult Index()
        {
            return View(db.LoaiDoAns.ToList());
        }

        // GET: Admin/LoaiDoAns/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiDoAn loaiDoAn = db.LoaiDoAns.Find(id);
            if (loaiDoAn == null)
            {
                return HttpNotFound();
            }
            return View(loaiDoAn);
        }

        // GET: Admin/LoaiDoAns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiDoAns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maLoaiDoAn,tenLoaiDoAn")] LoaiDoAn loaiDoAn)
        {

            if (ModelState.IsValid)
            {
                var loaiDoAn_exists = db.LoaiDoAns.SingleOrDefault(e => e.maLoaiDoAn == loaiDoAn.maLoaiDoAn);
                if(loaiDoAn_exists==null)
                {
                    if(loaiDoAn.maLoaiDoAn==null)
                    {
                        ModelState.AddModelError("maLoaiDoAn", "Mã loại đồ ăn không được để trống");
                    }
                    else if(loaiDoAn.tenLoaiDoAn==null)
                    {
                        ModelState.AddModelError("tenLoaiDoAn", "Tên loại đồ ăn không được để trống");
                    }
                    else
                    {
                        db.LoaiDoAns.Add(loaiDoAn);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }    
                   
                else
                {
                    ModelState.AddModelError("maLoaiDoAn", "Mã loại đồ ăn đã tồn tại");
                }
            }

            return View(loaiDoAn);
        }

        // GET: Admin/LoaiDoAns/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiDoAn loaiDoAn = db.LoaiDoAns.Find(id);
            if (loaiDoAn == null)
            {
                return HttpNotFound();
            }
            return View(loaiDoAn);
        }

        // POST: Admin/LoaiDoAns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maLoaiDoAn,tenLoaiDoAn")] LoaiDoAn loaiDoAn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiDoAn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiDoAn);
        }

        // GET: Admin/LoaiDoAns/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiDoAn loaiDoAn = db.LoaiDoAns.Find(id);
            if (loaiDoAn == null)
            {
                return HttpNotFound();
            }
            return View(loaiDoAn);
        }

        // POST: Admin/LoaiDoAns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LoaiDoAn loaiDoAn = db.LoaiDoAns.Find(id);
            db.LoaiDoAns.Remove(loaiDoAn);
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
