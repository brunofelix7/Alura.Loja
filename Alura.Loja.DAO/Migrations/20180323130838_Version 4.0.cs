using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Loja.Database.Migrations {

    public partial class Version40 : Migration {

        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.AlterColumn<string>(
                name: "Unidade",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.AlterColumn<int>(
                name: "Unidade",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
