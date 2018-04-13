using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DeveloperMovieProject.Models;

namespace DeveloperMovieProject.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public DateTime? Year { get; set; }

        [Required]
        public byte? GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Year = movie.Year;
            GenreId = movie.GenreId;
        }
    }
}