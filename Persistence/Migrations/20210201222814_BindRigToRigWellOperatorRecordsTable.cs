using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindRigToRigWellOperatorRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RigId",
                table: "RigWellOperatorRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RigWellOperatorRecords_RigId",
                table: "RigWellOperatorRecords",
                column: "RigId");

            migrationBuilder.AddForeignKey(
                name: "FK_RigWellOperatorRecords_Rigs_RigId",
                table: "RigWellOperatorRecords",
                column: "RigId",
                principalTable: "Rigs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RigWellOperatorRecords_Rigs_RigId",
                table: "RigWellOperatorRecords");

            migrationBuilder.DropIndex(
                name: "IX_RigWellOperatorRecords_RigId",
                table: "RigWellOperatorRecords");

            migrationBuilder.DropColumn(
                name: "RigId",
                table: "RigWellOperatorRecords");
        }
    }
}
