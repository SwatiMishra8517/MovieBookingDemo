using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class CinemaSeat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaSeatId { get; set; }
        [RegularExpression(@"^[A-Z]{1}[0-9]{2}", ErrorMessage = "Invalid Seat Number")]
        public string SeatNumber { get; set; }
        [Required(ErrorMessage = "Please enter Seat Type")]
        public int Type { get; set; }
        public int CinemaHallId { get; set; }

        public virtual CinemaHall CinemaHall { get; set; }
        public virtual ICollection<ShowSeat> Show_Seats { get; set; }
    }
    public enum Type
    {

    }
}