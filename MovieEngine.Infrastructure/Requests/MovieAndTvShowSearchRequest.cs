using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Requests
{
   public class MovieAndTvShowSearchRequest
    {
        public string Title { get; set; }
        public string Type { get; set; }
    }
}
