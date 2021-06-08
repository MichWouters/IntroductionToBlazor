using System;
using System.Collections.Generic;
using TodoBlazor.Models;

namespace TodoBlazor.Services
{
    public class MovieService : IMovieService
    {
        private IGenreService _genreService;

        public MovieService(IGenreService service)
        {
            _genreService = service;
        }

        private List<Movie> movies = new List<Movie>
            {
                new Movie{ Title = "Shrek", ReleaseDate=new DateTime(2001,1,1), GenreId = 1, Rating = 10, PosterImage="https://images-na.ssl-images-amazon.com/images/I/51%2BWoZieYBL._AC_.jpg"},
                new Movie{ Title = "Shrek 2", ReleaseDate=new DateTime(2004,1,1),GenreId = 1, Rating = 9.8, PosterImage="https://images-na.ssl-images-amazon.com/images/I/51nPzxasZTL._AC_.jpg"},
                new Movie { Title = "Shrek the Third", ReleaseDate= new DateTime(2007,1,1), GenreId = 2,Rating = 9.2, PosterImage="https://static.posters.cz/image/750/posters/shrek-3-friends-i1400.jpg" },
                new Movie { Title = "Shrek Forever After", ReleaseDate=new DateTime(2010,1,1), GenreId = 3, Rating = 8.9, PosterImage="https://cdn11.bigcommerce.com/s-wz20w6m762/images/stencil/1280x1280/products/12592/30042/7YP-Bt1WdRpoQTTHko-3ng__70322.1617101400.jpg?c=1" },
            };

        public List<Movie> GetMovies()
        {
            foreach (Movie movie in movies)
            {
                movie.Genre = _genreService.GetGenre(movie.GenreId);
            }

            return movies;
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
    }
}