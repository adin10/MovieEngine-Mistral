using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Database
{
   public class Actor:IAuditable
    {
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<MovieAndTvShowActor> MovieAndTvShowActor { get; set; }
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
