using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a movie's name.")]
        public string Name { get; set; }

        //[Display(Name = "Genre")]
        //[Required(ErrorMessage = "Please choose an genre")]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please choose an genre")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }

        //[Required]
        public DateTime? ReleaseDate { get; set; }

        
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }
    }
}