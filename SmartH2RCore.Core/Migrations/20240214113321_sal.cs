using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartH2RCore.Core.Migrations
{
    public partial class sal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salutation",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salutation",
                schema: "Employee",
                table: "JobDetails");
        }
    }
}
