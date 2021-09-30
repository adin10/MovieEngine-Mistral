using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Requests
{
   public class RatingRestUpsertModel
    {
        public int MovieAndTvShowId { get; set; }
        public int RatingValue { get; set; }
    }
}
