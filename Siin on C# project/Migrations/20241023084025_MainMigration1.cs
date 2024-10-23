using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_CristianPent_TARpe23.Migrations
{
    /// <inheritdoc />
    public partial class MainMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Wards",
                newName: "WardID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WardID",
                table: "Wards",
                newName: "DepartmentID");
        }
    }
}
