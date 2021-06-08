using System.Collections.Generic;
using System.Threading.Tasks;
using TodoBlazor.Models;

namespace TodoBlazor.Services
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
    }
}