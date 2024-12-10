using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogAdoption.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_135 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Dog");
        }
    }
}
