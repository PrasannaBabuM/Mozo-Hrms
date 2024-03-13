using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartH2RCore.Core.Migrations
{
    public partial class jbdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Relationship",
                schema: "Employee",
                table: "PersonalDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Percentage",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proficiency",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Relationship",
                schema: "Employee",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "Percentage",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "Proficiency",
                schema: "Employee",
                table: "JobDetails");
        }
    }
}
