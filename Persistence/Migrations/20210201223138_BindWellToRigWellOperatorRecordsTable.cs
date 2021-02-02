using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindWellToRigWellOperatorRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "WellId",
                table: "RigWellOperatorRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RigWellOperatorRecords_WellId",
                table: "RigWellOperatorRecords",
                column: "WellId");

            migrationBuilder.AddForeignKey(
                name: "FK_RigWellOperatorRecords_Wells_WellId",
                table: "RigWellOperatorRecords",
                column: "WellId",
                principalTable: "Wells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RigWellOperatorRecords_Wells_WellId",
                table: "RigWellOperatorRecords");

            migrationBuilder.DropIndex(
                name: "IX_RigWellOperatorRecords_WellId",
                table: "RigWellOperatorRecords");

            migrationBuilder.DropColumn(
                name: "WellId",
                table: "RigWellOperatorRecords");
        }
    }
}
