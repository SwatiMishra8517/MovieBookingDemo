using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }
    }
}