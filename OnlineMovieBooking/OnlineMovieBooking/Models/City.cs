using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        [DisplayName("City Name")]
        public string Name { get; set; }
        public string State { get; set; }
        [DisplayName("Zip Code")]
        [MaxLength(6)]
        public string ZipCode { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}