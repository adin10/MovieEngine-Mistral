using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Requests
{
   public class MovieAndTvShowInsertRequest
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PictureName { get; set; }
        public string PicturePath { get; set; }
        //public byte[] CoverImage { get; set; }

    }
}
