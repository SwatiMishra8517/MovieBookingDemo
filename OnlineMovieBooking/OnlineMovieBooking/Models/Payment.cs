using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieBooking.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public DateTime Time { get; set; }
        public string DiscountCouponId { get; set; }
        public string RemoteTransactionId { get; set; }
        public string PaymentMethod { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}