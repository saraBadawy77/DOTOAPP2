using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOTOAPP1.Migrations
{
    /// <inheritdoc />
    public partial class TestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApptestTables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogosPaths = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApptestTables", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApptestTables");
        }
    }
}
