using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a movie's name.")]
        public string Name { get; set; }

        //[Display(Name = "Genre")]
        //[Required(ErrorMessage = "Please choose an genre")]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please choose an genre")]
        [Display(Name = "Genre Type")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        //[Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }
    }
}