using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Requests
{
   public class RatingSearchRequest
    {
        public int? RatingValue { get; set; }
        public string Title { get; set; }
        public int? MovieAndTvShowID { get; set; }
    }
}
