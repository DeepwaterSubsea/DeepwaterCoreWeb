using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindRigOEMToAssetsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OEMId",
                table: "RigAssets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RigAssets_OEMId",
                table: "RigAssets",
                column: "OEMId");

            migrationBuilder.AddForeignKey(
                name: "FK_RigAssets_RigOEMs_OEMId",
                table: "RigAssets",
                column: "OEMId",
                principalTable: "RigOEMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RigAssets_RigOEMs_OEMId",
                table: "RigAssets");

            migrationBuilder.DropIndex(
                name: "IX_RigAssets_OEMId",
                table: "RigAssets");

            migrationBuilder.DropColumn(
                name: "OEMId",
                table: "RigAssets");
        }
    }
}
