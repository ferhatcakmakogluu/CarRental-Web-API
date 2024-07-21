using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UserAdressUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 17, 19, 0, 14, 797, DateTimeKind.Local).AddTicks(1437));
        }
    }
}
