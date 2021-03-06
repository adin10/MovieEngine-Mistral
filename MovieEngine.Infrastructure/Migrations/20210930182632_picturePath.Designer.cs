// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieEngine.Infrastructure.Context;

namespace MovieEngine.Infrastructure.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210930182632_picturePath")]
    partial class picturePath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieEngine.Database.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorID");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("MovieEngine.Database.MovieAndTvShow", b =>
                {
                    b.Property<int>("MovieAndTvShowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("CoverImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieAndTvShowID");

                    b.ToTable("MovieAndTvShow");
                });

            modelBuilder.Entity("MovieEngine.Database.MovieAndTvShowActor", b =>
                {
                    b.Property<int>("MovieAndTvShowActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<int>("MovieAndTvShowID")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieAndTvShowActorID");

                    b.HasIndex("ActorID");

                    b.HasIndex("MovieAndTvShowID");

                    b.ToTable("MovieAndTvShowActor");
                });

            modelBuilder.Entity("MovieEngine.Database.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieAndTvShowId")
                        .HasColumnType("int");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.HasKey("RatingID");

                    b.HasIndex("MovieAndTvShowId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("MovieEngine.Database.MovieAndTvShowActor", b =>
                {
                    b.HasOne("MovieEngine.Database.Actor", "Actor")
                        .WithMany("MovieAndTvShowActor")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieEngine.Database.MovieAndTvShow", "MovieAndTvShow")
                        .WithMany("MovieAndTvShowActor")
                        .HasForeignKey("MovieAndTvShowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("MovieAndTvShow");
                });

            modelBuilder.Entity("MovieEngine.Database.Rating", b =>
                {
                    b.HasOne("MovieEngine.Database.MovieAndTvShow", "MovieAndTvShow")
                        .WithMany()
                        .HasForeignKey("MovieAndTvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieAndTvShow");
                });

            modelBuilder.Entity("MovieEngine.Database.Actor", b =>
                {
                    b.Navigation("MovieAndTvShowActor");
                });

            modelBuilder.Entity("MovieEngine.Database.MovieAndTvShow", b =>
                {
                    b.Navigation("MovieAndTvShowActor");
                });
#pragma warning restore 612, 618
        }
    }
}
