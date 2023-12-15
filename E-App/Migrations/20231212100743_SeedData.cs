using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_App.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictucerURL",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Cinemas",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ProfilePictucerURL",
                table: "Actors",
                newName: "ProfilePictureURL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePictucerURL");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictucerURL");
        }
    }
}
