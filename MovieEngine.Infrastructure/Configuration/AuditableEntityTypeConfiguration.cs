using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieEngine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Configuration
{
    public class AuditableEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IAuditable
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasOne(x => x.CreatedUser).WithMany().HasForeignKey(x => x.CreatedUserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ModifiedUser).WithMany().HasForeignKey(x => x.ModifiedUserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.DeletedUser).WithMany().HasForeignKey(x => x.DeletedUserId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
