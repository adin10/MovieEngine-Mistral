using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Response
{
   public class RatingResponse
    {
        public int RatingID { get; set; }
        public int MovieAndTvShowId { get; set; }
        public MovieAndTvShow MovieAndTvShow { get; set; }
        public int RatingValue { get; set; }
    }
}
