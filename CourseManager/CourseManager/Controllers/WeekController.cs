using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;

namespace CourseManager.Controllers
{
    public class WeekController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        // GET: Week
        public ActionResult Index()
        {
            return View(db.Weeks.ToList());
        }

        // GET: Week/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weeks weeks = db.Weeks.Find(id);
            if (weeks == null)
            {
                return HttpNotFound();
            }
            return View(weeks);
        }

        // GET: Week/Create
        public ActionResult Create()
        {
            var courseId = db.Course.ToList();

            ViewBag.Courses = courseId;
            return View();
        }

        // POST: Week/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WeekId,SectionId,CourseId")] Weeks weeks)
        {
            if (ModelState.IsValid)
            {
                db.Weeks.Add(weeks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weeks);
        }

        // GET: Week/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weeks weeks = db.Weeks.Find(id);
            if (weeks == null)
            {
                return HttpNotFound();
            }
            return View(weeks);
        }

        // POST: Week/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WeekId,SectionId,CourseId")] Weeks weeks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weeks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weeks);
        }

        // GET: Week/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weeks weeks = db.Weeks.Find(id);
            if (weeks == null)
            {
                return HttpNotFound();
            }
            return View(weeks);
        }

        // POST: Week/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Weeks weeks = db.Weeks.Find(id);
            db.Weeks.Remove(weeks);
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
