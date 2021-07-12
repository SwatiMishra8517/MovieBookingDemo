using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class CinemaHall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaHallId { get; set; }
        [Required(ErrorMessage = "Please enter hall name"), MaxLength(30)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the number of seats")]
        [RegularExpression(@"^([0-9])$", ErrorMessage = "Invalid Number of seats.")]
        public int TotalSeats { get; set; }
        [Required(ErrorMessage = "Please select Cinema ID.")]
        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }
        public virtual ICollection<CinemaSeat> CinemaSeats { get; set; }
        public virtual ICollection<Show> Shows { get; set; }
    }
}