using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoBlazor.Models;

namespace TodoBlazor.Services
{
    public class GenreService : IGenreService
    {
        private List<Genre> genres = new List<Genre>
        {
            new Genre {Id = 1, Name = "Comedy", IsSuitableForChildren = true},
            new Genre {Id = 2, Name = "Action", IsSuitableForChildren = true},
            new Genre {Id = 3, Name = "Erotic", IsSuitableForChildren = false},
        };

        public List<Genre> GetGenres()
        {
            return genres;
        }

        public void AddGenre(Genre genre)
        {
            genres.Add(genre);
        }

        public void EditGenre(Genre genre)
        {
            var oldGenre = genres.FirstOrDefault(x => x.Id == genre.Id);
            oldGenre = genre;
        }

        public void DeleteGenre(Genre genre)
        {
            genres.Remove(genre);
        }
    }
}
