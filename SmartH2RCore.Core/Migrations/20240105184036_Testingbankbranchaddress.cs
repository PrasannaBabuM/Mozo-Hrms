using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartH2RCore.Core.Migrations
{
    public partial class Testingbankbranchaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branchaddress",
                schema: "Master",
                table: "Bank",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branchaddress",
                schema: "Master",
                table: "Bank");
        }
    }
}
