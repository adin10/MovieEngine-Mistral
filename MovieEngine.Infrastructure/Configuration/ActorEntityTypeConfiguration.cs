using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Configuration
{
   public class ActorEntityTypeConfiguration
    {
        public virtual void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasKey(x => x.ActorID);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();

        }
    }
}
