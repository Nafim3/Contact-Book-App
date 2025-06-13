using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Contact_Book_App.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContactEntries",
                columns: new[] { "Id", "Email", "FirstName", "Generated", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "ams4@gmail.com", "Amjad", new DateTime(2025, 6, 7, 18, 6, 51, 518, DateTimeKind.Local).AddTicks(4289), "Mustafa", "048917387135" },
                    { 2, "lY6@gmail.com", "Lamine", new DateTime(2025, 6, 7, 18, 6, 51, 518, DateTimeKind.Local).AddTicks(4821), "Yamal", "123456789014" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
