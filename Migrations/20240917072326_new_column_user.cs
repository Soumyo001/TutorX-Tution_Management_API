using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutor_X_Tution_Management.Migrations
{
    /// <inheritdoc />
    public partial class new_column_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userReports",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userReports",
                table: "user");
        }
    }
}
