using Microsoft.EntityFrameworkCore;
using MovieEngine.Database;
using MovieEngine.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<MovieAndTvShow> MovieAndTvShow { get; set; }
        public DbSet<MovieAndTvShowActor> MovieAndTvShowActor { get; set; }
        public DbSet<Rating> Rating { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MovieActorEntityTypeConfiguration).Assembly);

        }
    }
}
