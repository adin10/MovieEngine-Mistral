using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Configuration
{
   public class MovieActorEntityTypeConfiguration
    {
        public virtual void Configure(EntityTypeBuilder<MovieAndTvShowActor> builder)
        {
            builder.HasKey(x => x.MovieAndTvShowActorID);
            builder.HasOne(x => x.MovieAndTvShow).WithMany().HasForeignKey(x => x.MovieAndTvShowID);
            builder.HasOne(x => x.Actor).WithMany().HasForeignKey(x => x.ActorID);
            

        }
    }
}
