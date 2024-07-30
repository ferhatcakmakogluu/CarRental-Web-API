using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class x : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedCar_CarFeatures_CarFeatureId",
                table: "SavedCar");

            migrationBuilder.DropIndex(
                name: "IX_SavedCar_CarFeatureId",
                table: "SavedCar");

            migrationBuilder.DropColumn(
                name: "CarFeatureId",
                table: "SavedCar");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 1,
                column: "SavedTime",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 2,
                column: "SavedTime",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 3,
                column: "SavedTime",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 46, 19, 513, DateTimeKind.Local).AddTicks(9642));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarFeatureId",
                table: "SavedCar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "AccountCreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarFeatureId", "SavedTime" },
                values: new object[] { 4, new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarFeatureId", "SavedTime" },
                values: new object[] { 5, new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarFeatureId", "SavedTime" },
                values: new object[] { 6, new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2024, 7, 30, 17, 44, 37, 956, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.CreateIndex(
                name: "IX_SavedCar_CarFeatureId",
                table: "SavedCar",
                column: "CarFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedCar_CarFeatures_CarFeatureId",
                table: "SavedCar",
                column: "CarFeatureId",
                principalTable: "CarFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
