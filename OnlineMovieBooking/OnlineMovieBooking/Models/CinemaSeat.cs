using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Models
{
    public class CinemaSeat
    {
        public int CinemaSeatId { get; set; }
        public string SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallId { get; set; }
    }
}