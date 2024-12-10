using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogAdoption.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    DogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DogAge = table.Column<int>(type: "int", nullable: false),
                    DogWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DogBreed = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    IsVaccinated = table.Column<bool>(type: "bit", nullable: false),
                    IsNeutered = table.Column<bool>(type: "bit", nullable: false),
                    Temperament = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.DogID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionPosting",
                columns: table => new
                {
                    AdoptionPostingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionPosting", x => x.AdoptionPostingID);
                    table.ForeignKey(
                        name: "FK_AdoptionPosting_Dog_DogID",
                        column: x => x.DogID,
                        principalTable: "Dog",
                        principalColumn: "DogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionApplication",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DogID = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExtraInformation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    HasOtherPets = table.Column<bool>(type: "bit", nullable: false),
                    HasChildrenUnderTwelve = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionApplication", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_Dog_DogID",
                        column: x => x.DogID,
                        principalTable: "Dog",
                        principalColumn: "DogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_DogID",
                table: "AdoptionApplication",
                column: "DogID");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_UserID",
                table: "AdoptionApplication",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionPosting_DogID",
                table: "AdoptionPosting",
                column: "DogID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptionApplication");

            migrationBuilder.DropTable(
                name: "AdoptionPosting");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Dog");
        }
    }
}
