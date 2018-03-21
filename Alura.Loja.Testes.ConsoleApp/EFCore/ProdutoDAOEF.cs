using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp.EFCore {

    public class ProdutoDAOEF : IProdutoDAOEF, IDisposable {

        private LojaContext context;

        /* Cria o contexto */
        public ProdutoDAOEF() {
            this.context = new LojaContext();
        }

        /* Destroi o contexto */
        public void Dispose() {
            context.Dispose();
        }

        /* Salva um produto */
        public int Save(Produto produto) {
            int rowsAffected = 0;
            try {
                context.Produtos.Add(produto);
                rowsAffected = context.SaveChanges();
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Save error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Atualiza um produto */
        public int Update(Produto produto) {
            int rowsAffected = 0;
            try {
                context.Produtos.Update(produto);
                rowsAffected = context.SaveChanges();
                return rowsAffected;
            } catch(Exception e) {
                Debug.WriteLine("Update error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Exclui um produto */
        public int Delete(Produto produto) {
            int rowsAffected = 0;
            try {
                context.Produtos.Remove(produto);
                rowsAffected = context.SaveChanges();
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Delete error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Busca um produto */
        public Produto FindOne(int id) {
            try {
                Produto produto = context.Produtos.Find(id);
                return produto;
            } catch (Exception e) {
                Debug.WriteLine("FindOne error - " + e.Message);
                return null;
            }
        }

        /* Busca todos os produtos */
        public List<Produto> FindAll() {
            try {
                List<Produto> produtos = context.Produtos.ToList();
                return produtos;
            } catch (Exception e) {
                Debug.WriteLine("FindAll error - " + e.Message);
                return null;
            }
        }
    }
}
