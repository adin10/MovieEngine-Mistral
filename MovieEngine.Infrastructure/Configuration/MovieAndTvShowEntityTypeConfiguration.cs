using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;

namespace MovieEngine.Infrastructure.Configuration
{
   public class MovieAndTvShowEntityTypeConfiguration
    {
        public virtual void Configure(EntityTypeBuilder<MovieAndTvShow> builder)
        {
            builder.HasKey(x=>x.MovieAndTvShowID);
            builder.Property(x=>x.Title).IsRequired();
            
        }
    }
}
