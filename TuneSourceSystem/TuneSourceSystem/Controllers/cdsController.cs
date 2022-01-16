using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TuneSourceSystem;

namespace TuneSourceSystem.Controllers
{
    public class cdsController : Controller
    {
        private tunesourceEntities db = new tunesourceEntities();

        // GET: cds
        public ActionResult Index()
        {
            var cds = db.cds.Include(c => c.typeofmusic);
            return View(cds.ToList());
        }

        // GET: cds/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cd cd = db.cds.Find(id);
            if (cd == null)
            {
                return HttpNotFound();
            }
            return View(cd);
        }

        // GET: cds/Create
        public ActionResult Create()
        {
            ViewBag.type_id = new SelectList(db.typeofmusics, "type_id", "type_name");
            return View();
        }

        // POST: cds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cd_id,cd_title,cd_price,cd_details,cd_image,cd_established,type_id")] cd cd)
        {
            if (ModelState.IsValid)
            {
                db.cds.Add(cd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.type_id = new SelectList(db.typeofmusics, "type_id", "type_name", cd.type_id);
            return View(cd);
        }

        // GET: cds/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cd cd = db.cds.Find(id);
            if (cd == null)
            {
                return HttpNotFound();
            }
            ViewBag.type_id = new SelectList(db.typeofmusics, "type_id", "type_name", cd.type_id);
            return View(cd);
        }

        // POST: cds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cd_id,cd_title,cd_price,cd_details,cd_image,cd_established,type_id")] cd cd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.type_id = new SelectList(db.typeofmusics, "type_id", "type_name", cd.type_id);
            return View(cd);
        }

        // GET: cds/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cd cd = db.cds.Find(id);
            if (cd == null)
            {
                return HttpNotFound();
            }
            return View(cd);
        }

        // POST: cds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            cd cd = db.cds.Find(id);
            db.cds.Remove(cd);
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
