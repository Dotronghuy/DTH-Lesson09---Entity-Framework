using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson07___Entity_Framework.Models;

namespace Lesson07___Entity_Framework.Controllers
{
    public class dthKhoasController : Controller
    {
        private ĐTH_K22CNT1Lesson07Entities db = new ĐTH_K22CNT1Lesson07Entities();

        // GET: dthKhoas
        public ActionResult DTHIndex()
        {
            return View(db.dthKhoa.ToList());
        }

        // GET: dthKhoas/Details/5
        public ActionResult DTHDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthKhoa dthKhoa = db.dthKhoa.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // GET: dthKhoas/Create
        public ActionResult DTHCreate()
        {
            return View();
        }

        // POST: dthKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DTHCreate([Bind(Include = "ĐthID,ĐthTenKh,ĐthTrangthai")] dthKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.dthKhoa.Add(dthKhoa);
                db.SaveChanges();
                return RedirectToAction("DTHIndex");
            }

            return View(dthKhoa);
        }

        // GET: dthKhoas/Edit/5
        public ActionResult DTHEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthKhoa dthKhoa = db.dthKhoa.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // POST: dthKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DTHEdit([Bind(Include = "ĐthID,ĐthTenKh,ĐthTrangthai")] dthKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DTHIndex");
            }
            return View(dthKhoa);
        }

        // GET: dthKhoas/Delete/5
        public ActionResult DTHDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthKhoa dthKhoa = db.dthKhoa.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // POST: dthKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DTHDeleteConfirmed(string id)
        {
            dthKhoa dthKhoa = db.dthKhoa.Find(id);
            db.dthKhoa.Remove(dthKhoa);
            db.SaveChanges();
            return RedirectToAction("DTHIndex");
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
