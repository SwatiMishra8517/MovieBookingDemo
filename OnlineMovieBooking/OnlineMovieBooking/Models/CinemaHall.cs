using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Models
{
    public class CinemaHall
    {
        public int CinemaHallId { get; set; }
        public string Name { get; set; }
        public int TotalSeats { get; set; }
        public int CinemaId { get; set; }
    }
}