using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidyaCat2.Data;
using VidyaCat2.Models;
using VidyaCat2.Services;

namespace VidyaCat2.MVC.Controllers
{
    public class PlatformController : Controller
    {
        // GET: Platform
        public ActionResult Index()
        {
            var svc = new PlatformService();
            var model = svc.GetPlatforms();
            return View(model);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlatformCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var svc = new PlatformService();
            if (svc.CreatePlatform(model))
            {
                TempData["SaveResult"] = "Platform was successfully added to the database!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to add the platform to the database - changes not saved.");
            return View(model);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var svc = new PlatformService();
            var model = svc.GetPlatformByID(id);
            return View(model);
        }

        // GET: Platforms by Year
        public ActionResult IndexByYear(int year)
        {
            var svc = new PlatformService();
            var model = svc.GetPlatformsByYear(year);
            return View(model);
        }

        // GET: Platforms by Brand
        public ActionResult IndexByBrand(Brand brand)
        {
            var svc = new PlatformService();
            var model = svc.GetPlatformsByBrand(brand);
            return View(model);
        }

        // GET: Platforms by Status
        public ActionResult IndexByStatus(bool status)
        {
            var svc = new PlatformService();
            var model = svc.GetPlatformsByStatus(status);
            return View(model);
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var svc = new PlatformService();
            var detail = svc.GetPlatformByID(id);
            var model = new PlatformEdit
            {
                PlatformID = detail.PlatformID,
                Brand = detail.Brand,
                PlatformName = detail.PlatformName,
                ReleaseDate = detail.ReleaseDate
            };
            return View(model);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlatformEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.PlatformID != id)
            {
                ModelState.AddModelError("", "ID mismatch");
                return View(model);
            }

            var svc = new PlatformService();

            if (svc.UpdatePlatform(model))
            {
                TempData["SaveResult"] = "Platform info was successfully updated!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to update the platform info - changes not saved.");
            return View(model);
        }

        // GET: Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new PlatformService();
            var model = svc.GetPlatformByID(id);
            return View(model);
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeletePlatform(int id)
        {
            var svc = new PlatformService();
            svc.DeletePlatform(id);
            TempData["SaveResult"] = "Platform was successfully deleted!";
            return RedirectToAction("Index");
        }
    }
}