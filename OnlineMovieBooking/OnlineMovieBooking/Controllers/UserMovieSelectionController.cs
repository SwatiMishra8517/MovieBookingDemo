using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.Models;
using OnlineMovieBooking.Context;
namespace OnlineMovieBooking.Controllers
{
    public class UserMovieSelectionController : Controller
    {
        MovieContext db = new MovieContext();
        // GET: UserMovieSelection
        public ActionResult SelectCity()
        {
            IEnumerable<City> cityList = db.Cities.ToList();
            return View(cityList);
        }
        
        public ActionResult SelectCinemaByCity(int cityId)
        {
            IEnumerable<Cinema> cinemaList = db.Cinemas.Where(m=>m.CityId==cityId).ToList();
            return View(cinemaList);
                

        }

       
        public ActionResult SelectShowByCinema(int cinemaId)
        {
            IEnumerable<Show> showList = db.Shows.Where(m => m.CinemaHall.Cinema.CinemaId==cinemaId);
            return View(showList);
        }
        public ActionResult SelectShowByMovie(int movieId)
        {
            IEnumerable<Show> showsList = db.Shows.Where(m => m.MovieId == movieId);
            return View(showsList);
        }

    }
}