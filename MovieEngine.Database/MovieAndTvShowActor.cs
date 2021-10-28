using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Database
{
   public class MovieAndTvShowActor:IAuditable
    {
        public int MovieAndTvShowActorID { get; set; }
        public int MovieAndTvShowID { get; set; }
        public MovieAndTvShow MovieAndTvShow { get; set; }
        public int ActorID { get; set; }
        public Actor Actor { get; set; }
        public string Role { get; set; }
        public string RoleName { get; set; }
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
