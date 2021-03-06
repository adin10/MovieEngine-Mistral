using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Configuration
{
   public class ActorEntityTypeConfiguration:AuditableEntityTypeConfiguration<Actor>
    {
        public override void Configure(EntityTypeBuilder<Actor> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.ActorID);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();

        }
    }
}
