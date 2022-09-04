using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Recycle.Data;
using Recycle.Models;

namespace Recycle.Controllers
{
    public class RecyclableTypesController : Controller
    {
        private RecyclableDbContext db = new RecyclableDbContext();

        // GET: RecyclableTypes
        public ActionResult List()
        {
            return View(db.RecyclableType.ToList());
        }

        // GET: RecyclableTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecyclableTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Rate,MinKg,MaxKg")] RecyclableType recyclableType)
        {
            if (ModelState.IsValid)
            {
                db.RecyclableType.Add(recyclableType);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(recyclableType);
        }

        // GET: RecyclableTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecyclableType recyclableType = db.RecyclableType.Find(id);
            if (recyclableType == null)
            {
                return HttpNotFound();
            }
            return View(recyclableType);
        }

        // POST: RecyclableTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,Rate,MinKg,MaxKg")] RecyclableType recyclableType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recyclableType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(recyclableType);
        }

        // GET: RecyclableTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecyclableType recyclableType = db.RecyclableType.Find(id);
            if (recyclableType == null)
            {
                return HttpNotFound();
            }
            return View(recyclableType);
        }

        // POST: RecyclableTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecyclableType recyclableType = db.RecyclableType.Find(id);
            db.RecyclableType.Remove(recyclableType);
            db.SaveChanges();
            return RedirectToAction("List");
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
