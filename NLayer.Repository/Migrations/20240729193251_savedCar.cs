using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class savedCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavedCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    SavedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedCar_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.InsertData(
                table: "SavedCar",
                columns: new[] { "Id", "AccountId", "CarId", "SavedTime" },
                values: new object[,]
                {
                    { 1, 11, 4, new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3895) },
                    { 2, 11, 5, new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3896) },
                    { 3, 11, 6, new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3897) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.CreateIndex(
                name: "IX_SavedCar_CarId",
                table: "SavedCar",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedCar");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7125));
        }
    }
}
