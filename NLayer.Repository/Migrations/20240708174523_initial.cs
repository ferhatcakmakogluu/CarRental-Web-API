using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    AccountCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Km = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GearType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "LastName", "Name", "PhoneNumber", "Photo" },
                values: new object[,]
                {
                    { 1, "X Mahallesi ", "Cakmakoglu", "Ferhat", "12365478914", null },
                    { 2, "Y Mahallesi ", "Tellioglu", "Ahmet", "96325874125", null },
                    { 3, "Z Mahallesi ", "Can", "Kerem", "25874123654", null },
                    { 4, "C Mahallesi ", "Vurgun", "Ali", "58963214875", null },
                    { 5, "AA Mahallesi ", "Menur", "Veli", "98563210254", null }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountCreatedDate", "AccountType", "Email", "Password", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8374), "RENTER", "ferhatcakmakoglu@gmail.com", "123456", 1 },
                    { 2, new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8389), "RENTER", "tryit@gmail.com", "123456789", 2 },
                    { 3, new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8390), "RENTER", "helloworld@gmail.com", "147852369", 3 },
                    { 4, new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8392), "USER", "ali@gmail.com", "159852364", 4 },
                    { 5, new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8393), "USER", "veli@gmail.com", "236547895", 5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CreatedDate", "Description", "Model", "Photos", "Price", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, "BMW", new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8643), "Hızlı bir araba", "iX", null, 2300m, null, 1 },
                    { 2, "Volvo", new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8645), "Yol tutuşu harika bir araba", "XC90", null, 1950m, null, 1 },
                    { 3, "Fiat", new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8646), "Günlük içler için ideal", "Egea Multijet", null, 950m, null, 2 },
                    { 4, "Mercedes", new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8647), "Konfor harika", "E350", null, 1450m, null, 2 },
                    { 5, "Peugeot", new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8648), "Yeni nesil tasarım", "3008 Gt", null, 2750m, null, 2 },
                    { 6, "Audi", new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8650), "Modern, konforlu ve hızlı", "A8 Long", null, 3000m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "Id", "BodyType", "CarId", "Color", "FuelType", "GearType", "Km" },
                values: new object[,]
                {
                    { 1, "SEDAN", 1, "Kırmızı", "HYBRID", "SEMI_AUTOMATIC", "12500" },
                    { 2, "SUV", 2, "Gri", "DIESEL", "AUTOMATIC", "4500" },
                    { 3, "CROSSOVER", 3, "Mavi", "GASOLINE", "MANUEL", "111000" },
                    { 4, "SEDAN", 4, "Yeşil", "ELECTRIC", "SEMI_AUTOMATIC", "2150" },
                    { 5, "CROSSOVER", 5, "Turuncu", "DIESEL", "AUTOMATIC", "65000" },
                    { 6, "CROSSOVER", 6, "Siyah", "DIESEL", "AUTOMATIC", "35600" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
