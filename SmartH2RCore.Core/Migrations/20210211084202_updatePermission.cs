using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartH2RCore.Core.Migrations
{
    public partial class updatePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_ScreenMaster_ScreenMasterId",
                schema: "Permission",
                table: "RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenMaster_ModuleMaster_ModuleMasterId",
                schema: "Permission",
                table: "ScreenMaster");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                schema: "Permission",
                table: "ScreenMaster");

            migrationBuilder.DropColumn(
                name: "ScreenId",
                schema: "Permission",
                table: "RolePermission");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleMasterId",
                schema: "Permission",
                table: "ScreenMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScreenMasterId",
                schema: "Permission",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermission_ScreenMaster_ScreenMasterId",
                schema: "Permission",
                table: "RolePermission",
                column: "ScreenMasterId",
                principalSchema: "Permission",
                principalTable: "ScreenMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenMaster_ModuleMaster_ModuleMasterId",
                schema: "Permission",
                table: "ScreenMaster",
                column: "ModuleMasterId",
                principalSchema: "Permission",
                principalTable: "ModuleMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_ScreenMaster_ScreenMasterId",
                schema: "Permission",
                table: "RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenMaster_ModuleMaster_ModuleMasterId",
                schema: "Permission",
                table: "ScreenMaster");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleMasterId",
                schema: "Permission",
                table: "ScreenMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                schema: "Permission",
                table: "ScreenMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ScreenMasterId",
                schema: "Permission",
                table: "RolePermission",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ScreenId",
                schema: "Permission",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermission_ScreenMaster_ScreenMasterId",
                schema: "Permission",
                table: "RolePermission",
                column: "ScreenMasterId",
                principalSchema: "Permission",
                principalTable: "ScreenMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenMaster_ModuleMaster_ModuleMasterId",
                schema: "Permission",
                table: "ScreenMaster",
                column: "ModuleMasterId",
                principalSchema: "Permission",
                principalTable: "ModuleMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
