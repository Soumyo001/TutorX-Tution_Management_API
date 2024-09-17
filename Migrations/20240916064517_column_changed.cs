using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutor_X_Tution_Management.Migrations
{
    /// <inheritdoc />
    public partial class column_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tutorId",
                table: "messege",
                newName: "uidTo");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "messege",
                newName: "uidFrom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uidTo",
                table: "messege",
                newName: "tutorId");

            migrationBuilder.RenameColumn(
                name: "uidFrom",
                table: "messege",
                newName: "studentId");
        }
    }
}
