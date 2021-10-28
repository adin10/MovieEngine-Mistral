using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Database
{
   public class Rating:IAuditable
    {
        public int RatingID { get; set; }
        public int MovieAndTvShowId { get; set; }
        public MovieAndTvShow MovieAndTvShow { get; set; }
        public int RatingValue { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public IdentityUser<int> CreatedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public IdentityUser<int> ModifiedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedUserId { get; set; }
        public IdentityUser<int> DeletedUser { get; set; }
    }
}
