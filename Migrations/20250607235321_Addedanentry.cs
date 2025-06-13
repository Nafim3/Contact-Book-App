using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact_Book_App.Migrations
{
    /// <inheritdoc />
    public partial class Addedanentry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContactEntries",
                columns: new[] { "Id", "Email", "FirstName", "Generated", "LastName", "PhoneNumber" },
                values: new object[] { 3, "kn@gmail.com", "Kamran", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "891084735184" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
