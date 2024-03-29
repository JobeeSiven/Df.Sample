﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseManager.Filters;
using CourseManager.Models;

namespace CourseManager.Controllers
{
    [RequireAuthentication]
    [ActionResultExceptionFilter]
    public class SidebarsController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        // GET: Sidebars
        public ActionResult Index()
        {
            return View(db.Sidebars.ToList());
        }

        // GET: Sidebars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sidebars sidebars = db.Sidebars.Find(id);
            if (sidebars == null)
            {
                return HttpNotFound();
            }
            return View(sidebars);
        }

        // GET: Sidebars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sidebars/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Controller,Action")] Sidebars sidebars)
        {
            if (ModelState.IsValid)
            {
                db.Sidebars.Add(sidebars);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sidebars);
        }

        // GET: Sidebars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sidebars sidebars = db.Sidebars.Find(id);
            if (sidebars == null)
            {
                return HttpNotFound();
            }
            return View(sidebars);
        }

        // POST: Sidebars/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] Sidebars sidebars)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sidebars).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sidebars);
        }

        // GET: Sidebars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sidebars sidebars = db.Sidebars.Find(id);
            if (sidebars == null)
            {
                return HttpNotFound();
            }
            return View(sidebars);
        }

        // POST: Sidebars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sidebars sidebars = db.Sidebars.Find(id);
            db.Sidebars.Remove(sidebars);
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
