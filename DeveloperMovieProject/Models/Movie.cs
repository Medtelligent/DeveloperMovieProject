using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeveloperMovieProject.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        
        public DateTime Year { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}