using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieEngine.Infrastructure.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_Actor_ActorID",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_MovieAndTvShow_MovieAndTvShowId",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Rating",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Rating",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Rating",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Rating",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActorID1",
                table: "MovieAndTvShowActor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MovieAndTvShowActor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "MovieAndTvShowActor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MovieAndTvShowActor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "MovieAndTvShowActor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MovieAndTvShowActor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "MovieAndTvShowActor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieAndTvShowID1",
                table: "MovieAndTvShowActor",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MovieAndTvShow",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MovieAndTvShow",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "MovieAndTvShow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MovieAndTvShow",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "MovieAndTvShow",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MovieAndTvShow",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "MovieAndTvShow",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Actor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Actor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Actor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Actor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_AspNetUsers_DeletedUserId",
                        column: x => x.DeletedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_AspNetUsers_ModifiedUserId",
                        column: x => x.ModifiedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_CreatedUserId",
                table: "Rating",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_DeletedUserId",
                table: "Rating",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ModifiedUserId",
                table: "Rating",
                column: "ModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_ActorID1",
                table: "MovieAndTvShowActor",
                column: "ActorID1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_CreatedUserId",
                table: "MovieAndTvShowActor",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_DeletedUserId",
                table: "MovieAndTvShowActor",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_ModifiedUserId",
                table: "MovieAndTvShowActor",
                column: "ModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShowActor_MovieAndTvShowID1",
                table: "MovieAndTvShowActor",
                column: "MovieAndTvShowID1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShow_CreatedUserId",
                table: "MovieAndTvShow",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShow_DeletedUserId",
                table: "MovieAndTvShow",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndTvShow_ModifiedUserId",
                table: "MovieAndTvShow",
                column: "ModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_CreatedUserId",
                table: "Actor",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_DeletedUserId",
                table: "Actor",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_ModifiedUserId",
                table: "Actor",
                column: "ModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedUserId",
                table: "User",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DeletedUserId",
                table: "User",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedUserId",
                table: "User",
                column: "ModifiedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_userID",
                table: "User",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_AspNetUsers_CreatedUserId",
                table: "Actor",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_AspNetUsers_DeletedUserId",
                table: "Actor",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_AspNetUsers_ModifiedUserId",
                table: "Actor",
                column: "ModifiedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShow_AspNetUsers_CreatedUserId",
                table: "MovieAndTvShow",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShow_AspNetUsers_DeletedUserId",
                table: "MovieAndTvShow",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShow_AspNetUsers_ModifiedUserId",
                table: "MovieAndTvShow",
                column: "ModifiedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_Actor_ActorID",
                table: "MovieAndTvShowActor",
                column: "ActorID",
                principalTable: "Actor",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_Actor_ActorID1",
                table: "MovieAndTvShowActor",
                column: "ActorID1",
                principalTable: "Actor",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_AspNetUsers_CreatedUserId",
                table: "MovieAndTvShowActor",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_AspNetUsers_DeletedUserId",
                table: "MovieAndTvShowActor",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_AspNetUsers_ModifiedUserId",
                table: "MovieAndTvShowActor",
                column: "ModifiedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID",
                table: "MovieAndTvShowActor",
                column: "MovieAndTvShowID",
                principalTable: "MovieAndTvShow",
                principalColumn: "MovieAndTvShowID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID1",
                table: "MovieAndTvShowActor",
                column: "MovieAndTvShowID1",
                principalTable: "MovieAndTvShow",
                principalColumn: "MovieAndTvShowID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_AspNetUsers_CreatedUserId",
                table: "Rating",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_AspNetUsers_DeletedUserId",
                table: "Rating",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_AspNetUsers_ModifiedUserId",
                table: "Rating",
                column: "ModifiedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_MovieAndTvShow_MovieAndTvShowId",
                table: "Rating",
                column: "MovieAndTvShowId",
                principalTable: "MovieAndTvShow",
                principalColumn: "MovieAndTvShowID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_AspNetUsers_CreatedUserId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_AspNetUsers_DeletedUserId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_AspNetUsers_ModifiedUserId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShow_AspNetUsers_CreatedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShow_AspNetUsers_DeletedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShow_AspNetUsers_ModifiedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_Actor_ActorID",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_Actor_ActorID1",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_AspNetUsers_CreatedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_AspNetUsers_DeletedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_AspNetUsers_ModifiedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID1",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_AspNetUsers_CreatedUserId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_AspNetUsers_DeletedUserId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_AspNetUsers_ModifiedUserId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_MovieAndTvShow_MovieAndTvShowId",
                table: "Rating");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Rating_CreatedUserId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_DeletedUserId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_ModifiedUserId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShowActor_ActorID1",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShowActor_CreatedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShowActor_DeletedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShowActor_ModifiedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShowActor_MovieAndTvShowID1",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShow_CreatedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShow_DeletedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropIndex(
                name: "IX_MovieAndTvShow_ModifiedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_Actor_CreatedUserId",
                table: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_DeletedUserId",
                table: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_ModifiedUserId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "ActorID1",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "MovieAndTvShowID1",
                table: "MovieAndTvShowActor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "MovieAndTvShow");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Actor");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MovieAndTvShow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_Actor_ActorID",
                table: "MovieAndTvShowActor",
                column: "ActorID",
                principalTable: "Actor",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieAndTvShowActor_MovieAndTvShow_MovieAndTvShowID",
                table: "MovieAndTvShowActor",
                column: "MovieAndTvShowID",
                principalTable: "MovieAndTvShow",
                principalColumn: "MovieAndTvShowID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_MovieAndTvShow_MovieAndTvShowId",
                table: "Rating",
                column: "MovieAndTvShowId",
                principalTable: "MovieAndTvShow",
                principalColumn: "MovieAndTvShowID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
