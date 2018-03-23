using Alura.Loja.DAO.Interface;
using Alura.Loja.Database.DataContext;
using Alura.Loja.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Alura.Loja.Database.DAO {

    public class CompraDAO : ICompraDAO, IDisposable {

        private LojaContext context;

        /* Cria o contexto */
        public CompraDAO() {
            this.context = new LojaContext();
        }

        /* Destroi o contexto */
        public void Dispose() {
            context.Dispose();
        }

        /* Salva uma compra */
        public int Save(Compra compra) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Compras.Add(compra);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Save error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Atualiza uma compra */
        public int Update(Compra compra) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Compras.Update(compra);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Update error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Exclui uma compra */
        public int Delete(Compra compra) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Compras.Remove(compra);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Delete error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Busca uma compra */
        public Compra FindOne(int id) {
            try {
                context.ShowSQL(context);
                Compra compra = context.Compras.Find(id);
                context.ShowEntityState(context);
                return compra;
            } catch (Exception e) {
                Debug.WriteLine("FindOne error - " + e.Message);
                return null;
            }
        }

        /* Busca todas as compras */
        public List<Compra> FindAll() {
            try {
                context.ShowSQL(context);
                List<Compra> compras = context.Compras.ToList();
                context.ShowEntityState(context);
                return compras;
            } catch (Exception e) {
                Debug.WriteLine("FindAll error - " + e.Message);
                return null;
            }
        }
    }
}
