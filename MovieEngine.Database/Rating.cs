using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Database
{
   public class Rating
    {
        public int RatingID { get; set; }
        public int MovieAndTvShowId { get; set; }
        public MovieAndTvShow MovieAndTvShow { get; set; }
        public int RatingValue { get; set; }

    }
}
