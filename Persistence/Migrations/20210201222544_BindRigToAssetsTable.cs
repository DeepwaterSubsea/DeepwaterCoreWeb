using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindRigToAssetsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RigId",
                table: "RigAssets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RigAssets_RigId",
                table: "RigAssets",
                column: "RigId");

            migrationBuilder.AddForeignKey(
                name: "FK_RigAssets_Rigs_RigId",
                table: "RigAssets",
                column: "RigId",
                principalTable: "Rigs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RigAssets_Rigs_RigId",
                table: "RigAssets");

            migrationBuilder.DropIndex(
                name: "IX_RigAssets_RigId",
                table: "RigAssets");

            migrationBuilder.DropColumn(
                name: "RigId",
                table: "RigAssets");
        }
    }
}
