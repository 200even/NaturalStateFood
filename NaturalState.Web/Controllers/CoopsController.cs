using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NaturalState.Web.Models;

namespace NaturalState.Web.Controllers
{
    public class CoopsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Coops
        public ActionResult Index()
        {
            return View(db.Coops.ToList());
        }

        // GET: Coops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coop coop = db.Coops.Find(id);
            if (coop == null)
            {
                return HttpNotFound();
            }
            return View(coop);
        }

        // GET: Coops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,City,State,Phone,Url,Email,MembershipCost,MedianIncome,Population,IsOpen")] Coop coop)
        {
            if (ModelState.IsValid)
            {
                db.Coops.Add(coop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coop);
        }

        // GET: Coops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coop coop = db.Coops.Find(id);
            if (coop == null)
            {
                return HttpNotFound();
            }
            return View(coop);
        }

        // POST: Coops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,City,State,Phone,Url,Email,MembershipCost,MedianIncome,Population,IsOpen")] Coop coop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coop);
        }

        // GET: Coops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coop coop = db.Coops.Find(id);
            if (coop == null)
            {
                return HttpNotFound();
            }
            return View(coop);
        }

        // POST: Coops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coop coop = db.Coops.Find(id);
            db.Coops.Remove(coop);
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
