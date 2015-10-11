using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppProj.Models;

namespace WebAppProj.Controllers
{
    public class lecturesController : Controller
    {
        private lectureDb db = new lectureDb();

        // GET: lectures
        public ActionResult Index()
        {
            var lectures = db.lectures.Include(l => l.instructor);
            return View(lectures.ToList());
        }

        // GET: lectures/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lecture lecture = db.lectures.Find(id);
            if (lecture == null)
            {
                return HttpNotFound();
            }
            return View(lecture);
        }

        // GET: lectures/Create
        public ActionResult Create()
        {
            ViewBag.instructorId = new SelectList(db.instructors, "instructorId", "firstName");
            return View();
        }

        // POST: lectures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lectureId,name,location,instructorId,startDate,endDate")] lecture lecture)
        {
            if (ModelState.IsValid)
            {
                db.lectures.Add(lecture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.instructorId = new SelectList(db.instructors, "instructorId", "firstName", lecture.instructorId);
            return View(lecture);
        }

        // GET: lectures/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lecture lecture = db.lectures.Find(id);
            if (lecture == null)
            {
                return HttpNotFound();
            }
            ViewBag.instructorId = new SelectList(db.instructors, "instructorId", "firstName", lecture.instructorId);
            return View(lecture);
        }

        // POST: lectures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lectureId,name,location,instructorId,startDate,endDate")] lecture lecture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lecture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.instructorId = new SelectList(db.instructors, "instructorId", "firstName", lecture.instructorId);
            return View(lecture);
        }

        // GET: lectures/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lecture lecture = db.lectures.Find(id);
            if (lecture == null)
            {
                return HttpNotFound();
            }
            return View(lecture);
        }

        // POST: lectures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            lecture lecture = db.lectures.Find(id);
            db.lectures.Remove(lecture);
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
