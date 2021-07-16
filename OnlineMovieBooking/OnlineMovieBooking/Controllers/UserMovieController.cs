using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using OnlineMovieBooking.Context;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext db = new MovieContext();
        // GET: Movie
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            Movie movie = db.Movies.Find(id);
            return View(movie);
        }
        public ActionResult FeedBack(int? id)
        {
            Movie movie = db.Movies.Find(id);
            Feedback feedback = db.Feedbacks.Where(m => m.MovieId == id).FirstOrDefault();
            return View(feedback);
        }
        public ActionResult AddFeedBack()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeedBack(Feedback feedback)
        {
            if(ModelState.IsValid)
            {
                db.Feedbacks.Add(feedback);
                return RedirectToAction("Details", feedback.MovieId);
            }
            return View();
        }

    }

}