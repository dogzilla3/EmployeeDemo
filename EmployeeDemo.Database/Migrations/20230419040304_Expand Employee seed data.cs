using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDemo.Database.Migrations
{
    /// <inheritdoc />
    public partial class ExpandEmployeeseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5184), "Dax", "Mcclellan", "Kipton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5240), "Carter", "Merritt", "Konnor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5243), "Finnian", "Raymond", "Gianluca" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5246), "Sara", "Stanton", "Leilany" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5249), "Darion", "Fournier", "Zavion" },
                    { 6, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5252), "Charlee", "Lake", "Leilany" },
                    { 7, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5254), "Dario", "Durham", "Reese" },
                    { 8, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5366), "Kyron", "Messer", "Sterling" },
                    { 9, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5372), "Alek", "White", "Jakoby" },
                    { 10, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5375), "Kenna", "Mccarty", "Janely" },
                    { 11, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5377), "Kassandra", "Drake", "Dulce" },
                    { 12, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5380), "Jackson", "Salgado", "Nova" },
                    { 13, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5383), "Hasan", "Meyer", "Elias" },
                    { 14, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5385), "Rosemary", "Yeager", "Camryn" },
                    { 15, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5388), "Dominic", "Mccarty", "Gilberto" },
                    { 16, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5391), "Katarina", "Crosby", "Dalia" },
                    { 17, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5393), "Wren", "Parsons", "Linda" },
                    { 18, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5396), "Julie", "Preston", "Ansley" },
                    { 19, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5399), "Tyce", "Hackett", "Zaine" },
                    { 20, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5401), "Kaiden", "Simpson", "Josiah" },
                    { 21, new DateTime(2023, 4, 18, 23, 3, 4, 601, DateTimeKind.Local).AddTicks(5404), "Trae", "Lehman", "Elliott" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8898), "William", "Shakespeare", "Bob" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8959), "John", "Doe", "Ron" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8963), "Larry", "Bird", "Bill" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[] { new DateTime(2023, 4, 18, 11, 18, 30, 12, DateTimeKind.Local).AddTicks(8967), "Matt", "Geer", "Linus" });
        }
    }
}
