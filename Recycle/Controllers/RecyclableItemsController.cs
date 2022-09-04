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
    public class RecyclableItemsController : Controller
    {
        private RecyclableDbContext db = new RecyclableDbContext();

        // GET: RecyclableItems
        public ActionResult List()
        {
            var recyclableItem = db.RecyclableItem.Include(r => r.RecyclableType);
            return View(recyclableItem.ToList());
        }

        // GET: RecyclableItems/Create
        public ActionResult Create()
        {
            ViewBag.RecyclableId = new SelectList(db.RecyclableType, "Id", "Type");
            return View();
        }

        // POST: RecyclableItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RecyclableId,Description,Weight,ComputedRate")] RecyclableItem recyclableItem)
        {
            if (ModelState.IsValid)
            {
                db.RecyclableItem.Add(recyclableItem);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            ViewBag.RecyclableId = new SelectList(db.RecyclableType, "Id", "Type", "Rate", recyclableItem.RecyclableId);
            return View(recyclableItem);
        }

        // GET: RecyclableItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecyclableItem recyclableItem = db.RecyclableItem.Find(id);
            if (recyclableItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.RecyclableId = new SelectList(db.RecyclableType, "Id", "Type", recyclableItem.RecyclableId);
            return View(recyclableItem);
        }

        // POST: RecyclableItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RecyclableId,Description,Weight,ComputedRate")] RecyclableItem recyclableItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recyclableItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            ViewBag.RecyclableId = new SelectList(db.RecyclableType, "Id", "Type", recyclableItem.RecyclableId);
            return View(recyclableItem);
        }

        // GET: RecyclableItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecyclableItem recyclableItem = db.RecyclableItem.Find(id);
            if (recyclableItem == null)
            {
                return HttpNotFound();
            }
            return View(recyclableItem);
        }

        // POST: RecyclableItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecyclableItem recyclableItem = db.RecyclableItem.Find(id);
            db.RecyclableItem.Remove(recyclableItem);
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
