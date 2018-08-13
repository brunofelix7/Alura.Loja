using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Loja.Database.Migrations {

    public partial class Version10 : Migration {

        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    PrecoUnidade = table.Column<double>(nullable: false),
                    Unidade = table.Column<int>(nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
