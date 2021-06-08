using System;
using System.ComponentModel.DataAnnotations;

namespace TodoBlazor.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titel is vereist")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(typeof(DateTime), "01/01/1950", "01/01/2021", ErrorMessage = "Datum moet tussen 1950 en 2021 liggen")]
        public DateTime ReleaseDate { get; set; }

        [Range(0,10, ErrorMessage = "Rating moet tussen 0 en 10 liggen")]
        public double Rating { get; set; }

        public string PosterImage { get; internal set; }

        public bool IsInTheaters { get; set; }
    }
}