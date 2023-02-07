using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Students_StudentId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Bookings",
                newName: "StudentIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_StudentId",
                table: "Bookings",
                newName: "IX_Bookings_StudentIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Students_StudentIDId",
                table: "Bookings",
                column: "StudentIDId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Students_StudentIDId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "StudentIDId",
                table: "Bookings",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_StudentIDId",
                table: "Bookings",
                newName: "IX_Bookings_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Students_StudentId",
                table: "Bookings",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
