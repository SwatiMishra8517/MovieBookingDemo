using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMovieBooking.Controllers
{
    public class UserFilterController : Controller
    {
        // GET: UserFilter
        public ActionResult Cities()
        {
            return View();
        }
    }
}