using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Skladište.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kreirao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Izmijenio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DatumBrisanja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategorija");
        }
    }
}
