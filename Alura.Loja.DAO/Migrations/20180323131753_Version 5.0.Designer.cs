using Alura.Loja.Database.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Loja.Database.Migrations {

    [DbContext(typeof(LojaContext))]
    [Migration("20180323131753_Version 5.0")]
    partial class Version50 {

        protected override void BuildTargetModel(ModelBuilder modelBuilder) {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Model.Compra", b => {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<double>("Preco");

                b.Property<int?>("ProdutoId");

                b.Property<int>("Quantidade");

                b.HasKey("Id");

                b.HasIndex("ProdutoId");

                b.ToTable("Compras");
            });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Produto", b => {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Categoria");

                b.Property<string>("Nome");

                b.Property<double>("PrecoUnidade");

                b.Property<string>("Unidade");

                b.HasKey("Id");

                b.ToTable("Produtos");
            });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Model.Compra", b => {
                b.HasOne("Alura.Loja.Testes.ConsoleApp.Produto", "Produto")
                    .WithMany()
                    .HasForeignKey("ProdutoId");
            });
        }
    }
}
