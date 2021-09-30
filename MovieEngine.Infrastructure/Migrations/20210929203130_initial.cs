using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieEngine.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndTvShow",
                columns: table => new
                {
                    MovieAndTvShowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoverImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndTvShow", x => x.MovieAndTvShowID);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndTvShowActor",
                columns: table => new
                {
                    MovieAndTvShowActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTvShowID = table.Column<int>(type: "int", nullable: false),
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndTvShowActor", x => x.MovieAndTvShowActorID);
                    table.ForeignKey(
                        name: "FK_MovieAndTvShowActor_Actor_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actor",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID",
                        column: x => x.MovieAndTvShowID,
                        principalTable: "MovieAndTvShow",
                        principalColumn: "MovieAndTvShowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieAndTvShowId = table.Column<int>(type: "int", nullable: false),
                    RatingValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Rating_MovieAndTvShow_MovieAndTvShowId",
                        column: x => x.MovieAndTvShowId,
                        principalTable: "MovieAndTvShow",
                        principalColumn: "MovieAndTvShowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_ActorID",
                table: "MovieAndTvShowActor",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_MovieAndTvShowID",
                table: "MovieAndTvShowActor",
                column: "MovieAndTvShowID");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_MovieAndTvShowId",
                table: "Rating",
                column: "MovieAndTvShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieAndTvShowActor");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "MovieAndTvShow");
        }
    }
}
