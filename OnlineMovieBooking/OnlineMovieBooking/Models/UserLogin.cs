using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieBooking.Models
{
    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}