using Alura.Loja.DAO.Interface;
using Alura.Loja.Database.DataContext;
using Alura.Loja.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Alura.Loja.Database.DAO {

    public class ProdutoDAO : IProdutoDAO, IDisposable {

        private LojaContext context;

        /* Cria o contexto */
        public ProdutoDAO() {
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
                context.ShowSQL(context);
                context.Produtos.Add(produto);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
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
                context.ShowSQL(context);
                context.Produtos.Update(produto);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Update error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Exclui um produto */
        public int Delete(Produto produto) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Produtos.Remove(produto);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Delete error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Busca um produto */
        public Produto FindOne(int id) {
            try {
                context.ShowSQL(context);
                Produto produto = context.Produtos.Find(id);
                context.ShowEntityState(context);
                return produto;
            } catch (Exception e) {
                Debug.WriteLine("FindOne error - " + e.Message);
                return null;
            }
        }

        /* Busca todos os produtos */
        public List<Produto> FindAll() {
            try {
                context.ShowSQL(context);
                List<Produto> produtos = context.Produtos.ToList();
                context.ShowEntityState(context);
                return produtos;
            } catch (Exception e) {
                Debug.WriteLine("FindAll error - " + e.Message);
                return null;
            }
        }
    }
}
