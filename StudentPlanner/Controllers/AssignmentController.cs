﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentPlanner.Models;

namespace StudentPlanner.Controllers
{
    public class AssignmentController : Controller
    {
        private CourseContext db = new CourseContext();

        // GET: Assignment
        public ActionResult Index()
        {
            var assignments = db.Assignments.Include(a => a.Course);
            return View(assignments.ToList());
        }

        // GET: Assignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignments assignments = db.Assignments.Find(id);
            if (assignments == null)
            {
                return HttpNotFound();
            }
            return View(assignments);
        }

        // GET: Assignment/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Course, "ID", "CourseTitle");
            return View();
        }

        // POST: Assignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AssignmentName,DueDate,CourseID")] Assignments assignments)
        {
            if (ModelState.IsValid)
            {
                db.Assignments.Add(assignments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Course, "ID", "CourseTitle", assignments.CourseID);
            return View(assignments);
        }

        // GET: Assignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignments assignments = db.Assignments.Find(id);
            if (assignments == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Course, "ID", "CourseTitle", assignments.CourseID);
            return View(assignments);
        }

        // POST: Assignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AssignmentName,DueDate,CourseID")] Assignments assignments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Course, "ID", "CourseTitle", assignments.CourseID);
            return View(assignments);
        }

        // GET: Assignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignments assignments = db.Assignments.Find(id);
            if (assignments == null)
            {
                return HttpNotFound();
            }
            return View(assignments);
        }

        // POST: Assignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assignments assignments = db.Assignments.Find(id);
            db.Assignments.Remove(assignments);
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
