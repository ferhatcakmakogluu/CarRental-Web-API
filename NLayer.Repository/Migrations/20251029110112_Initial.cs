using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Password = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    AccountCreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AccountType = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Brand = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    Model = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Photos = table.Column<List<string>>(type: "text[]", nullable: true),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Color = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Km = table.Column<string>(type: "text", nullable: false),
                    FuelType = table.Column<string>(type: "text", nullable: false),
                    BodyType = table.Column<string>(type: "text", nullable: false),
                    GearType = table.Column<string>(type: "text", nullable: false),
                    CarId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "SavedCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    CarId = table.Column<int>(type: "integer", nullable: false),
                    SavedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedCar_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedCar_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "BirthDate", "Email", "LastName", "Name", "Password", "PhoneNumber", "Photo" },
                values: new object[,]
                {
                    { 1, "X Mahallesi ", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6780), "ferhat@gmail.com", "Cakmakoglu", "Ferhat", "Fe.147852639", "12365478914", null },
                    { 2, "Y Mahallesi ", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6780), "ahmet@gmail.com", "Tellioglu", "Ahmet", "Ah.147852639", "96325874125", null },
                    { 3, "Z Mahallesi ", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6780), "kerem@gmail.com", "Can", "Kerem", "Ke.147852639", "25874123654", null },
                    { 4, "C Mahallesi ", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6790), "ali@gmail.com", "Vurgun", "Ali", "Al.147852639", "58963214875", null },
                    { 5, "AA Mahallesi ", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6790), "veli@gmail.com", "Menur", "Veli", "Ve.147852639", "98563210254", null }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountCreatedDate", "AccountType", "Email", "Password", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6520), "RENTER", "ferhatcakmakoglu@gmail.com", "123456", 1 },
                    { 2, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6520), "RENTER", "tryit@gmail.com", "123456789", 2 },
                    { 3, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6520), "RENTER", "helloworld@gmail.com", "147852369", 3 },
                    { 4, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6520), "USER", "ali@gmail.com", "159852364", 4 },
                    { 5, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6520), "USER", "veli@gmail.com", "236547895", 5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CreatedDate", "Description", "Location", "Model", "Photos", "Price", "State", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, "BMW", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6670), "Hızlı bir araba", "Türkiye", "iX", null, 2300m, "İstanbul", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6670), 1 },
                    { 2, "Volvo", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6670), "Yol tutuşu harika bir araba", "Türkiye", "XC90", null, 1950m, "Ankara", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6670), 1 },
                    { 3, "Fiat", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6670), "Günlük içler için ideal", "Türkiye", "Egea Multijet", null, 950m, "İzmir", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6670), 2 },
                    { 4, "Mercedes", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6680), "Konfor harika", "Türkiye", "E350", null, 1450m, "Bursa", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6680), 2 },
                    { 5, "Peugeot", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6680), "Yeni nesil tasarım", "Türkiye", "3008 Gt", null, 2750m, "Trabzon", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6680), 2 },
                    { 6, "Audi", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6680), "Modern, konforlu ve hızlı", "Türkiye", "A8 Long", null, 3000m, "Zonguldak", new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6680), 3 }
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

            migrationBuilder.InsertData(
                table: "SavedCar",
                columns: new[] { "Id", "AccountId", "CarId", "SavedTime" },
                values: new object[,]
                {
                    { 1, 1, 4, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6740) },
                    { 2, 1, 5, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6740) },
                    { 3, 1, 6, new DateTime(2025, 10, 29, 11, 1, 11, 869, DateTimeKind.Utc).AddTicks(6740) }
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

            migrationBuilder.CreateIndex(
                name: "IX_SavedCar_AccountId",
                table: "SavedCar",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedCar_CarId",
                table: "SavedCar",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "SavedCar");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
