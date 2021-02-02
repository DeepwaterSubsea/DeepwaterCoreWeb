using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BindRigContractorToRigsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ContractorId",
                table: "Rigs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Rigs_ContractorId",
                table: "Rigs",
                column: "ContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rigs_RigContractors_ContractorId",
                table: "Rigs",
                column: "ContractorId",
                principalTable: "RigContractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rigs_RigContractors_ContractorId",
                table: "Rigs");

            migrationBuilder.DropIndex(
                name: "IX_Rigs_ContractorId",
                table: "Rigs");

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Rigs");
        }
    }
}
