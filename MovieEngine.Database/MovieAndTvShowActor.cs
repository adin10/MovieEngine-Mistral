using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Database
{
   public class MovieAndTvShowActor
    {
        public int MovieAndTvShowActorID { get; set; }
        public int MovieAndTvShowID { get; set; }
        public MovieAndTvShow MovieAndTvShow { get; set; }
        public int ActorID { get; set; }
        public Actor Actor { get; set; }
        public string Role { get; set; }
        public string RoleName { get; set; }
    }
}
