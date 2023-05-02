using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDemo.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Supervisors",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Jameson", "Bruce", "Bear" },
                    { 2, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Sammie", "Kaylee", "Catherin" },
                    { 3, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Vinal", "Gabe", "Jerrod" },
                    { 4, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Carissa", "Austen", "Novalee" },
                    { 5, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Brady", "Micah", "Fay" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "MiddleName", "SupervisorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Dax", "Mcclellan", "Kipton", 1 },
                    { 2, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Carter", "Merritt", "Konnor", 1 },
                    { 3, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Finnian", "Raymond", "Gianluca", 1 },
                    { 4, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Sara", "Stanton", "Leilany", 1 },
                    { 5, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Darion", "Fournier", "Zavion", 1 },
                    { 6, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Charlee", "Lake", "Leilany", 2 },
                    { 7, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Dario", "Durham", "Reese", 2 },
                    { 8, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Kyron", "Messer", "Sterling", 2 },
                    { 9, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Alek", "White", "Jakoby", 2 },
                    { 10, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Kenna", "Mccarty", "Janely", 2 },
                    { 11, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Kassandra", "Drake", "Dulce", 3 },
                    { 12, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Jackson", "Salgado", "Nova", 3 },
                    { 13, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Hasan", "Meyer", "Elias", 3 },
                    { 14, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Rosemary", "Yeager", "Camryn", 3 },
                    { 15, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Dominic", "Mccarty", "Gilberto", 3 },
                    { 16, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Katarina", "Crosby", "Dalia", 4 },
                    { 17, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Wren", "Parsons", "Linda", 4 },
                    { 18, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Julie", "Preston", "Ansley", 4 },
                    { 19, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Tyce", "Hackett", "Zaine", 4 },
                    { 20, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Kaiden", "Simpson", "Josiah", 4 },
                    { 21, new DateTime(2023, 4, 19, 9, 45, 52, 530, DateTimeKind.Local), "Trae", "Lehman", "Elliott", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SupervisorId",
                table: "Employees",
                column: "SupervisorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Supervisors");
        }
    }
}
