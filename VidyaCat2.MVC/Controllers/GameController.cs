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
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var svc = new GameService();
            var model = svc.GetGames();
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
        public ActionResult Create(GameCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var svc = new GameService();
            if (svc.CreateGame(model))
            {
                TempData["SaveResult"] = "Game successfully added to database!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to add the game to the database - changes not saved.");
            return View(model);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var svc = new GameService();
            var model = svc.GetGameByID(id);
            return View(model);
        }

        // GET: Games by Developer
        public ActionResult IndexByDeveloper(int id)
        {
            var svc = new GameService();
            var model = svc.GetGamesByDeveloper(id);
            return View(model);
        }

        // GET: Games by Platform
        public ActionResult IndexByPlatform(int id)
        {
            var svc = new GameService();
            var model = svc.GetGamesByPlatform(id);
            return View(model);
        }

        // GET: Games by Year
        public ActionResult IndexByYear(int year)
        {
            var svc = new GameService();
            var model = svc.GetGamesByYear(year);
            return View(model);
        }

        // GET: Games by Genre
        public ActionResult IndexByGenre(Genre genre)
        {
            var svc = new GameService();
            var model = svc.GetGamesByGenre(genre);
            return View(model);
        }

        // GET: Games by Rating
        public ActionResult IndexByRating(Rating rating)
        {
            var svc = new GameService();
            var model = svc.GetGamesByRating(rating);
            return View(model);
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var svc = new GameService();
            var detail = svc.GetGameByID(id);
            var model = new GameEdit
            {
                GameID = detail.GameID,
                GameTitle = detail.GameTitle,
                ReleaseDate = detail.ReleaseDate,
                Genre = detail.Genre,
                FirstSubgenre = detail.FirstSubgenre,
                SecondSubgenre = detail.SecondSubgenre,
                ThirdSubgenre = detail.ThirdSubgenre,
                Rating = detail.Rating,
                DeveloperID = detail.DeveloperID,
                PlatformID = detail.PlatformID
            };

            return View(model);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GameEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.GameID != id)
            {
                ModelState.AddModelError("", "ID mismatch");
                return View(model);
            }

            var svc = new GameService();
            if (svc.UpdateGame(model))
            {
                TempData["SaveResult"] = "Game info was successfully updated!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to edit game info - changes not saved.");
            return View(model);
        }

        // GET: Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new GameService();
            var model = svc.GetGameByID(id);
            return View(model);
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteGame(int id)
        {
            var svc = new GameService();
            svc.DeleteGame(id);
            TempData["SaveResult"] = "Game successfully deleted from database.";
            return RedirectToAction("Index");
        }
    }
}