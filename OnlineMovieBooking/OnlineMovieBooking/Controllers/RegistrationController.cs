using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.Context;
using OnlineMovieBooking.Models;
namespace OnlineMovieBooking.Controllers
{
    
    public class RegistrationController : Controller
    {
        MovieContext db = new MovieContext();

        // GET: Registration
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            return RedirectToAction("Home");
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}