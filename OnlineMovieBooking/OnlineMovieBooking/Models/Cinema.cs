using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Models
{
    public class Cinema
    {
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public int TotalHalls { get; set; }
        public int CityId { get; set; }
    }
}