 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartH2RCore.Core.Migrations
{
    public partial class jobdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobDetails_Company_CompanyId",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "Employee",
                table: "JobDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeCode",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddelName",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Suffix",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemsPayableNumber",
                schema: "Employee",
                table: "JobDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobDetails_Company_CompanyId",
                schema: "Employee",
                table: "JobDetails",
                column: "CompanyId",
                principalSchema: "Company",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobDetails_Company_CompanyId",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "Alias",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "EmployeeCode",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "MiddelName",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "Suffix",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.DropColumn(
                name: "SystemsPayableNumber",
                schema: "Employee",
                table: "JobDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "Employee",
                table: "JobDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_JobDetails_Company_CompanyId",
                schema: "Employee",
                table: "JobDetails",
                column: "CompanyId",
                principalSchema: "Company",
                principalTable: "Company",
                principalColumn: "Id");
        }
    }
}
