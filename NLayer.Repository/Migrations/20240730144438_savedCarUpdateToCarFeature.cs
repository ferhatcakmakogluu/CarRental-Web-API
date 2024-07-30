using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class savedCarUpdateToCarFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_SavedCar_AccountId",
                table: "SavedCar",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedCar_CarFeatureId",
                table: "SavedCar",
                column: "CarFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedCar_Accounts_AccountId",
                table: "SavedCar",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedCar_CarFeatures_CarFeatureId",
                table: "SavedCar",
                column: "CarFeatureId",
                principalTable: "CarFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedCar_Accounts_AccountId",
                table: "SavedCar");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedCar_CarFeatures_CarFeatureId",
                table: "SavedCar");

            migrationBuilder.DropIndex(
                name: "IX_SavedCar_AccountId",
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

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 1,
                column: "SavedTime",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 2,
                column: "SavedTime",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "SavedCar",
                keyColumn: "Id",
                keyValue: 3,
                column: "SavedTime",
                value: new DateTime(2024, 7, 29, 22, 32, 50, 871, DateTimeKind.Local).AddTicks(3897));

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
        }
    }
}
