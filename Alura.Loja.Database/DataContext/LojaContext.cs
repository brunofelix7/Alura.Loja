using Alura.Loja.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Alura.Loja.Database.DataContext {

    public class LojaContext : DbContext {

        //  Classes que serão persistidas pelo Entity Framework. Tem que ser sempre o nome da tabela
        internal DbSet<Produto> Produtos { get; set; }
        internal DbSet<Compra> Compras { get; set; }
        internal DbSet<Promocao> Promocoes { get; set; }

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

        //  No momento da criacao do meu modelo adiciona configuracoes
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //  Cria uma chave primária composta
            modelBuilder.Entity<PromocaoProduto>().HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
            base.OnModelCreating(modelBuilder);
        }

        /* Retorna o status e dados das entidades. Rastreia todas as mudancas que estao acontecendo naquela instancia do contexto */
        public void ShowEntityState(LojaContext context) {
            IEnumerable<EntityEntry> entities = context.ChangeTracker.Entries();
            foreach (EntityEntry item in entities) {
                //  Unchanged(SELECT) | Modified(UPDATE) | Added(INSERT) | Deleted(DELETE) | Detached(NAO MONITORADO)
                Debug.WriteLine($"Entity/Status: {item.Entity.ToString()} - {item.State}");
            }
        }

        /* Retorna o SQL gerado pelo EFCore */
        public void ShowSQL(LojaContext context) {
            var serviceProvider = context.GetInfrastructure<IServiceProvider>();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(SqlLoggerProvider.Create());
        }
    }
}
