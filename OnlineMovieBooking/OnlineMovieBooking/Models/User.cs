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
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Username")]
        [MaxLength(15)]
        [RegularExpression("^[a-z0-9]*$", ErrorMessage = "Only Small case Alphabets and Numbers allowed.")] 
        public string Username { get; set; }
        [DisplayName("Mobile Number")]
        [Required(ErrorMessage = "Please enter your Mobile Number"), MaxLength(10)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number. Please enter valid mobile number.")]
        public string MobileNo { get; set; }
        [DisplayName("Email Id")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your Email ID"), MaxLength(30)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please set the password")]
        [RegularExpression("/(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8}/g", ErrorMessage = "Password must meet requirements")]
        public string Password { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}