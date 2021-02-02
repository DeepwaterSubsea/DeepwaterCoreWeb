using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRigsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    RigPrefix = table.Column<string>(maxLength: 5, nullable: true),
                    shipBSEEId = table.Column<string>(maxLength: 10, nullable: true),
                    shipId = table.Column<string>(maxLength: 10, nullable: false),
                    shipMMSI = table.Column<string>(maxLength: 10, nullable: false),
                    shipIMO = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rigs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rigs");
        }
    }
}
