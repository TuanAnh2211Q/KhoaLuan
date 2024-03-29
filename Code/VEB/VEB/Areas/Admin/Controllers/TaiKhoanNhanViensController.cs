﻿using System;
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
    public class TaiKhoanNhanViensController : Controller
    {
        private DBQLCHTAN db = new DBQLCHTAN();

        // GET: Admin/TaiKhoanNhanViens
        public ActionResult Index()
        {
            var taiKhoanNhanViens = db.TaiKhoanNhanViens.Include(t => t.PhanQuyen);
            return View(taiKhoanNhanViens.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TaiKhoanNhanVien taiKhoanNhanVien)
        {
           
                var tk = db.TaiKhoanNhanViens.FirstOrDefault(e => e.tenTaiKhoan == taiKhoanNhanVien.tenTaiKhoan);
                if (tk != null)
                {
                    if (taiKhoanNhanVien.matKhau == tk.matKhau)
                        return RedirectToAction("Index", "Admin");
                    else
                        ModelState.AddModelError("", "Tên đăng nhập hoặc tại khoản không đúng vui lòng kiểm tra lại");
                }
           
            return View("Login");
        }
        // GET: Admin/TaiKhoanNhanViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoanNhanVien taiKhoanNhanVien = db.TaiKhoanNhanViens.Find(id);
            if (taiKhoanNhanVien == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoanNhanVien);
        }

        // GET: Admin/TaiKhoanNhanViens/Create
        public ActionResult Create()
        {
            ViewBag.maQuyen = new SelectList(db.PhanQuyens, "maQuyen", "tenQuyen");
            return View();
        }

        // POST: Admin/TaiKhoanNhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

      
        public ActionResult Create([Bind(Include = "id,tenTaiKhoan,matKhau,maNhanVien,maQuyen")] TaiKhoanNhanVien taiKhoanNhanVien)
        {
            if (ModelState.IsValid)
            {
                db.TaiKhoanNhanViens.Add(taiKhoanNhanVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maQuyen = new SelectList(db.PhanQuyens, "maQuyen", "tenQuyen", taiKhoanNhanVien.maQuyen);
            return View(taiKhoanNhanVien);
        }

        // GET: Admin/TaiKhoanNhanViens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoanNhanVien taiKhoanNhanVien = db.TaiKhoanNhanViens.Find(id);
            if (taiKhoanNhanVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.maQuyen = new SelectList(db.PhanQuyens, "maQuyen", "tenQuyen", taiKhoanNhanVien.maQuyen);
            return View(taiKhoanNhanVien);
        }

        // POST: Admin/TaiKhoanNhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tenTaiKhoan,matKhau,maNhanVien,maQuyen")] TaiKhoanNhanVien taiKhoanNhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taiKhoanNhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maQuyen = new SelectList(db.PhanQuyens, "maQuyen", "tenQuyen", taiKhoanNhanVien.maQuyen);
            return View(taiKhoanNhanVien);
        }

        // GET: Admin/TaiKhoanNhanViens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoanNhanVien taiKhoanNhanVien = db.TaiKhoanNhanViens.Find(id);
            if (taiKhoanNhanVien == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoanNhanVien);
        }

        // POST: Admin/TaiKhoanNhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaiKhoanNhanVien taiKhoanNhanVien = db.TaiKhoanNhanViens.Find(id);
            db.TaiKhoanNhanViens.Remove(taiKhoanNhanVien);
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
