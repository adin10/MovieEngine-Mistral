using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieEngine.Infrastructure.Migrations
{
    public partial class picturePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureName",
                table: "MovieAndTvShow",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "MovieAndTvShow",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureName",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "MovieAndTvShow");
        }
    }
}
