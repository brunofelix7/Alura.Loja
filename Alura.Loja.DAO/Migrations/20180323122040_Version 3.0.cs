using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Loja.Database.Migrations {

    public partial class Version30 : Migration {

        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.AddColumn<string>(
                name: "Disponivel",
                table: "Produtos",
                nullable: true);
        }
    }
}
