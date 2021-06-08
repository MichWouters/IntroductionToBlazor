using System.Collections.Generic;
using TodoBlazor.Models;

namespace TodoBlazor.Services
{
    public interface IGenreService
    {
        void AddGenre(Genre genre);
        void DeleteGenre(Genre genre);
        void EditGenre(Genre genre);
        List<Genre> GetGenres();
        Genre GetGenre(int genreId);
    }
}