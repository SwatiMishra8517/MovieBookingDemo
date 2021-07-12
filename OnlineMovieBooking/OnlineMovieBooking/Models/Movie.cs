using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        [DisplayName("Movie Name")]
        public string Name { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        [DisplayName("Duration(in mins)")]
        public int Duration { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> ReleaseDate { get; set; }

        public virtual ICollection<Show> Shows { get; set; }
    }
}