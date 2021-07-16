using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class UserInterfaceController : Controller
    {
        
        // GET: UserInterface
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/UserLogin/Login");
        }
    }
}