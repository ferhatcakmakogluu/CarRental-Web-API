using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addPasswordToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1431), "Fe.147852639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1433), "Ah.147852639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1435), "Ke.147852639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1436), "Al.147852639" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1437), "Ve.147852639" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 18, 54, 55, 204, DateTimeKind.Local).AddTicks(2485));
        }
    }
}
