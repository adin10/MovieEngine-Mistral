using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Configuration
{
   public class RatingEntityTypeConfiguration:AuditableEntityTypeConfiguration<Rating>
    {
        public override void Configure(EntityTypeBuilder<Rating> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.RatingID);
            builder.Property(x => x.RatingValue).IsRequired();
            builder.HasOne(x => x.MovieAndTvShow).WithMany().HasForeignKey(x => x.MovieAndTvShowId);

        }
    }
}
