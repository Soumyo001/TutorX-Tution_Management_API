using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutor_X_Tution_Management.Migrations
{
    /// <inheritdoc />
    public partial class changed_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tutorId",
                table: "report",
                newName: "uidTo");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "report",
                newName: "uidFrom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uidTo",
                table: "report",
                newName: "tutorId");

            migrationBuilder.RenameColumn(
                name: "uidFrom",
                table: "report",
                newName: "studentId");
        }
    }
}
