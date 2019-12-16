using Microsoft.EntityFrameworkCore.Migrations;

namespace RCN.Scafoold.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produtos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Produtos",
                newName: "Codigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produtos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Produtos",
                newName: "Documento");
        }
    }
}
