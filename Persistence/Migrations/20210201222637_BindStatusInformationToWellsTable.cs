using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindStatusInformationToWellsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "Wells",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Wells_StatusId",
                table: "Wells",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wells_StatusInformation_StatusId",
                table: "Wells",
                column: "StatusId",
                principalTable: "StatusInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wells_StatusInformation_StatusId",
                table: "Wells");

            migrationBuilder.DropIndex(
                name: "IX_Wells_StatusId",
                table: "Wells");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Wells");
        }
    }
}
