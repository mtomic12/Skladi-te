using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Skladište.DAL.Migrations
{
    /// <inheritdoc />
    public partial class stravka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stavke",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Količina = table.Column<int>(type: "int", nullable: false),
                    KategorijaId = table.Column<long>(type: "bigint", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kreirao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Izmijenio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DatumBrisanja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stavke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stavke_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_KategorijaId",
                table: "Stavke",
                column: "KategorijaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stavke");
        }
    }
}
