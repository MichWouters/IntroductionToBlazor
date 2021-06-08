using System.Collections.Generic;
using TodoBlazor.Models;

namespace TodoBlazor.Services
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Title = "Shrek", ReleaseYear=2001, Rating = 10, PosterImage="https://images-na.ssl-images-amazon.com/images/I/51%2BWoZieYBL._AC_.jpg"},
                new Movie{ Title = "Shrek 2", ReleaseYear=2004, Rating = 9.8, PosterImage="https://images-na.ssl-images-amazon.com/images/I/51nPzxasZTL._AC_.jpg"},
                new Movie { Title = "Shrek the Third", ReleaseYear = 2007, Rating = 9.2, PosterImage="https://static.posters.cz/image/750/posters/shrek-3-friends-i1400.jpg" },
                new Movie { Title = "Shrek Forever After", ReleaseYear = 2010, Rating = 8.9, PosterImage="https://cdn11.bigcommerce.com/s-wz20w6m762/images/stencil/1280x1280/products/12592/30042/7YP-Bt1WdRpoQTTHko-3ng__70322.1617101400.jpg?c=1" },
            };
        }
    }
}