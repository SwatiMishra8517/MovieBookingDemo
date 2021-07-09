using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieBooking.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}