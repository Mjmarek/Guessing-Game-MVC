using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["answer"] = new Random().Next(1, 10);
            return View();
        }

        private bool GuessWasCorrect(int guess) =>
            guess == (int)Session["answer"];
            //(int) is a cast, which explicitly tells program that "answer" is stored as an int

        [HttpPost]//This is an attribute, which describes how code should behave.
        [ValidateAntiForgeryToken]//makes sure user is who he says he is; makes sure session id tokens match
        public ActionResult Index(GameModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }
            return View(model);
        }
    }
}