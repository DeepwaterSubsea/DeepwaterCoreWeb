using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindOperatorToRigWellOperatorRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OperatorId",
                table: "RigWellOperatorRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RigWellOperatorRecords_OperatorId",
                table: "RigWellOperatorRecords",
                column: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_RigWellOperatorRecords_RigOperators_OperatorId",
                table: "RigWellOperatorRecords",
                column: "OperatorId",
                principalTable: "RigOperators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RigWellOperatorRecords_RigOperators_OperatorId",
                table: "RigWellOperatorRecords");

            migrationBuilder.DropIndex(
                name: "IX_RigWellOperatorRecords_OperatorId",
                table: "RigWellOperatorRecords");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "RigWellOperatorRecords");
        }
    }
}
