using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}