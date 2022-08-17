using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JourJournal.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JournalList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JournalList");
        }
    }
}
