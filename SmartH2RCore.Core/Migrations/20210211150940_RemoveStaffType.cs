using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartH2RCore.Core.Migrations
{
    public partial class RemoveStaffType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchStaffType",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "StaffType",
                schema: "Master");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffType",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchStaffType",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    StaffTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchStaffType", x => new { x.BranchId, x.StaffTypeId });
                    table.ForeignKey(
                        name: "FK_BranchStaffType_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchStaffType_StaffType_StaffTypeId",
                        column: x => x.StaffTypeId,
                        principalSchema: "Master",
                        principalTable: "StaffType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchStaffType_StaffTypeId",
                schema: "Company",
                table: "BranchStaffType",
                column: "StaffTypeId");
        }
    }
}
