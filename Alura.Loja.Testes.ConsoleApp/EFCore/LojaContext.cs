using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp.EFCore {

    public class LojaContext : DbContext {

        public LojaContext() {

        }

        //  Para configurar o MySQL
        public LojaContext(DbContextOptions<LojaContext> options) : base(options) {

        }

        //  Realiza a conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder connectionString) {
            if (!connectionString.IsConfigured) {
                connectionString.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }
        }

        //  Classes que serão persistidas pelo Entity Framework. Tem que ser sempre o nome da tabela
        internal DbSet<Produto> Produtos { get; set; }

        //  No momento da criacao do meu modelo adiciona configuracoes
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}
