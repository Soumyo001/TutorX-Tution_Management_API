using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutor_X_Tution_Management.Migrations
{
    /// <inheritdoc />
    public partial class ComponentUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tutorId",
                table: "request",
                newName: "uidTo");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "request",
                newName: "uidFrom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uidTo",
                table: "request",
                newName: "tutorId");

            migrationBuilder.RenameColumn(
                name: "uidFrom",
                table: "request",
                newName: "studentId");
        }
    }
}
