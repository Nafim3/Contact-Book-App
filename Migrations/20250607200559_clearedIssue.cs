using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact_Book_App.Migrations
{
    /// <inheritdoc />
    public partial class clearedIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Generated",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Generated",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Generated",
                value: new DateTime(2025, 6, 7, 18, 6, 51, 518, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "ContactEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Generated",
                value: new DateTime(2025, 6, 7, 18, 6, 51, 518, DateTimeKind.Local).AddTicks(4821));
        }
    }
}
