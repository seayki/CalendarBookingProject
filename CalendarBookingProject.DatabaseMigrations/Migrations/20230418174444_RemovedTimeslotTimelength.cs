using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarBookingProject.DatabaseMigrations.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTimeslotTimelength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeSlotLength",
                table: "Timeslots");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeSlotLength",
                table: "Timeslots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
