using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Skladište.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NadKategorijaId",
                table: "Kategorija",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategorija_NadKategorijaId",
                table: "Kategorija",
                column: "NadKategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategorija_Kategorija_NadKategorijaId",
                table: "Kategorija",
                column: "NadKategorijaId",
                principalTable: "Kategorija",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategorija_Kategorija_NadKategorijaId",
                table: "Kategorija");

            migrationBuilder.DropIndex(
                name: "IX_Kategorija_NadKategorijaId",
                table: "Kategorija");

            migrationBuilder.DropColumn(
                name: "NadKategorijaId",
                table: "Kategorija");
        }
    }
}
