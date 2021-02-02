using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRigWellOperatorRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RigWellOperatorRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BOP = table.Column<string>(maxLength: 7, nullable: false),
                    LMRP = table.Column<string>(maxLength: 7, nullable: false),
                    LatchDate = table.Column<DateTime>(nullable: false),
                    UnlatchDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigWellOperatorRecords", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RigWellOperatorRecords");
        }
    }
}
