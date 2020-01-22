using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website_Code_333.Models;

namespace Website_Code_333.Controllers
{
    public class CatController : Controller
    {

       public webDbContex db = new webDbContex();

        // GET: Cat
        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="name, age, color, gender,  breed")] CatProfile @catProfile )
        {
            if (ModelState.IsValid)
            {
                db.CatProfiles.Add(@catProfile);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatProfile profile = db.CatProfiles.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CatProfile profile = db.CatProfiles.Find(id);
            db.CatProfiles.Remove(profile);
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

        public ActionResult List()
        {
            return View(db.CatProfiles.ToList());
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}