using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WheelEstate.DAL;
using WheelEstate.Models;

namespace WheelEstate.Controllers
{
    public class RoadTripsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RoadTrips
        public ActionResult Index()
        {
            return View(db.RoadTrips.ToList());
        }

        // GET: RoadTrips/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoadTrip roadTrip = db.RoadTrips.Find(id);
            if (roadTrip == null)
            {
                return HttpNotFound();
            }
            return View(roadTrip);
        }

        // GET: RoadTrips/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoadTrips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,StartDate,EndDate,CreatedDate,ModifiedDate,UserName")] RoadTrip roadTrip)
        {
            if (ModelState.IsValid)
            {
                roadTrip.Id = Guid.NewGuid();
                roadTrip.UserName = User.Identity.Name;
                db.RoadTrips.Add(roadTrip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roadTrip);
        }

        // GET: RoadTrips/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoadTrip roadTrip = db.RoadTrips.Find(id);
            if (roadTrip == null)
            {
                return HttpNotFound();
            }
            return View(roadTrip);
        }

        // POST: RoadTrips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,StartDate,EndDate,CreatedDate,ModifiedDate,UserName")] RoadTrip roadTrip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roadTrip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roadTrip);
        }

        // GET: RoadTrips/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoadTrip roadTrip = db.RoadTrips.Find(id);
            if (roadTrip == null)
            {
                return HttpNotFound();
            }
            return View(roadTrip);
        }

        // POST: RoadTrips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            RoadTrip roadTrip = db.RoadTrips.Find(id);
            db.RoadTrips.Remove(roadTrip);
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
