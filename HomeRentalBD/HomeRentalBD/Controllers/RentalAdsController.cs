using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeRentalBD.Models;

namespace HomeRentalBD.Controllers
{
    public class RentalAdsController : Controller
    {
        private RentalAdsDbContext db = new RentalAdsDbContext();

        //
        // GET: /RentalAds/

        public ActionResult Index()
        {
            return View(db.RantalSet.ToList());
        }

        //
        // GET: /RentalAds/Details/5

        public ActionResult Details(int id = 0)
        {
            RentalAds rentalads = db.RantalSet.Find(id);
            if (rentalads == null)
            {
                return HttpNotFound();
            }
            return View(rentalads);
        }

        //
        // GET: /RentalAds/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RentalAds/Create

        [HttpPost]
        public ActionResult Create(RentalAds rentalads)
        {
            if (ModelState.IsValid)
            {
                db.RantalSet.Add(rentalads);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rentalads);
        }

        //
        // GET: /RentalAds/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RentalAds rentalads = db.RantalSet.Find(id);
            if (rentalads == null)
            {
                return HttpNotFound();
            }
            return View(rentalads);
        }

        //
        // POST: /RentalAds/Edit/5

        [HttpPost]
        public ActionResult Edit(RentalAds rentalads)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentalads).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rentalads);
        }

        //
        // GET: /RentalAds/Delete/5

        public ActionResult Delete(int id = 0)
        {
            RentalAds rentalads = db.RantalSet.Find(id);
            if (rentalads == null)
            {
                return HttpNotFound();
            }
            return View(rentalads);
        }

        //
        // POST: /RentalAds/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RentalAds rentalads = db.RantalSet.Find(id);
            db.RantalSet.Remove(rentalads);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}