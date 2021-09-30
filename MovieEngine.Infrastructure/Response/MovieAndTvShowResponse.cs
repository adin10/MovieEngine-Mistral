using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Response
{
   public class MovieAndTvShowResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] CoverImage { get; set; }

        public ICollection<MovieAndTvShowActor> MovieAndTvShowActor { get; set; }
    }
}
