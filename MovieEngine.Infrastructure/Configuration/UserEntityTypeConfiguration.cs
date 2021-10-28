using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Configuration
{
   public class UserEntityTypeConfiguration:AuditableEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.HasOne(x => x.user).WithMany().HasForeignKey(x => x.userID);
        }
    }
}
