using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieBooking.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public int TotalHalls { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<CinemaHall> CinemaHalls { get; set; }
    }
}