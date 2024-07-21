using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationToCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "Location", "State" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7046), "Türkiye", "İstanbul" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Location", "State" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7048), "Türkiye", "Ankara" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Location", "State" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7050), "Türkiye", "İzmir" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Location", "State" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7051), "Türkiye", "Bursa" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Location", "State" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7053), "Türkiye", "Trabzon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Location", "State" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 59, 37, 218, DateTimeKind.Local).AddTicks(7054), "Türkiye", "Zonguldak" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 11, 11, 552, DateTimeKind.Local).AddTicks(6251));
        }
    }
}
