using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarBookingProject.DatabaseMigrations.Migrations
{
    /// <inheritdoc />
    public partial class CrudWorkingMaybe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Teachers_TeacherId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Groups_GroupId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_GroupId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Calendars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CalendarGroup",
                columns: table => new
                {
                    CalendarsId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarGroup", x => new { x.CalendarsId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_CalendarGroup_Calendars_CalendarsId",
                        column: x => x.CalendarsId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarGroup_GroupId",
                table: "CalendarGroup",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Teachers_TeacherId",
                table: "Bookings",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Teachers_TeacherId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "CalendarGroup");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Calendars");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Calendars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_GroupId",
                table: "Calendars",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Teachers_TeacherId",
                table: "Bookings",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Groups_GroupId",
                table: "Calendars",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
