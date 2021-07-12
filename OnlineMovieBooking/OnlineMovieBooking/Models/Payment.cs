using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        public DateTime Time { get; set; }
        public string DiscountCouponId { get; set; }
        public string RemoteTransactionId { get; set; }
        public string PaymentMethod { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}