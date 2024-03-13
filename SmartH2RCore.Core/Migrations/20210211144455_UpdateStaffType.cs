using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartH2RCore.Core.Migrations
{
    public partial class UpdateStaffType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flag",
                schema: "Master",
                table: "StaffType");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Master",
                table: "StaffType",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Master",
                table: "StaffType");

            migrationBuilder.AddColumn<int>(
                name: "Flag",
                schema: "Master",
                table: "StaffType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
