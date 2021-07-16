 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMovieBooking.Models;
using System.Web.Mvc;
using OnlineMovieBooking.Context;
using System.Web.Security;

namespace OnlineMovieBooking.Controllers
{

    public class UserLoginController : Controller
    {
        MovieContext db = new MovieContext();
        // GET: UserLogin
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLogin user)
        {
            if (IsValidUserName(user))
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);

                return RedirectToAction("Index", "UserInterface");
            }
            

           
            else
            {
                return View();
            }

            
        }
        public bool IsValidUserName(UserLogin user)
        {

            User user1 = db.Users.Where(m => m.Username == user.Username).FirstOrDefault();
            User user2 = db.Users.Where(m => m.Email == user.Username).FirstOrDefault();
            if(user1!=null)
            {
                return user.Password == user1.Password;
            }
            else
            {
                return user.Password == user2.Password;
            }

            
        }

       
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}