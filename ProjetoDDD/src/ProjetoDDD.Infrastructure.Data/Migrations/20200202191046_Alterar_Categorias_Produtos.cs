using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDDD.Infrastructure.Data.Migrations
{
    public partial class Alterar_Categorias_Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "CategoriasProdutos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "CategoriasProdutos");
        }
    }
}
