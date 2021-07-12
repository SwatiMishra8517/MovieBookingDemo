using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Cinema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaId { get; set; }
        [DisplayName("Cinema Name")]
        public string Name { get; set; }
        [DisplayName("Cinema Halls")]
        public int TotalHalls { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<CinemaHall> CinemaHalls { get; set; }
    }
}