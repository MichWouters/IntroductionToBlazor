using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazor.Models
{
    public class Movie
    {
        public string Title { get; set; }

        public int ReleaseYear { get; set; }

        public double Rating { get; set; }
        public string PosterImage { get; internal set; }
    }
}
