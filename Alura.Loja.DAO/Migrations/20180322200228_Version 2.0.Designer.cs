using Alura.Loja.Database.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Loja.Database.Migrations {

    [DbContext(typeof(LojaContext))]
    [Migration("20180322200228_Version 2.0")]
    partial class Version20 {

        protected override void BuildTargetModel(ModelBuilder modelBuilder) {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Produto", b => {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Categoria");

                b.Property<string>("Disponivel");

                b.Property<string>("Nome");

                b.Property<double>("PrecoUnidade");

                b.Property<int>("Unidade");

                b.HasKey("Id");

                b.ToTable("Produtos");
            });
        }
    }
}
