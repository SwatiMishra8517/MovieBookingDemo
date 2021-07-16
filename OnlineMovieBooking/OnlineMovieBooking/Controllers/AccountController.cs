using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.Models;
namespace OnlineMovieBooking.Controllers
{
    public class AccountController : Controller
    {
        // GET: Registration
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            return RedirectToAction("Home/Index");
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            return Redirect("Login");
        }
    }
}