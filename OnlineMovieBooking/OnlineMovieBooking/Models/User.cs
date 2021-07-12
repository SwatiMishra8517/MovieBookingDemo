using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        
        public string Name { get; set; }
        [MaxLength(15)]
        public string Username { get; set; }
        [DisplayName("Mobile Number")]
        public string MobileNo { get; set; }
        [DisplayName("Email Id")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}