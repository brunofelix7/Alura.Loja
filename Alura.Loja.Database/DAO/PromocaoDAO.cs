using Alura.Loja.Database.DataContext;
using Alura.Loja.Database.Interface;
using Alura.Loja.Model.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Alura.Loja.Database.DAO {

    public class PromocaoDAO : IPromocaoDAO, IDisposable{

        private LojaContext context;

        /* Cria o contexto */
        public PromocaoDAO() {
            this.context = new LojaContext();
        }

        /* Destroi o contexto */
        public void Dispose() {
            context.Dispose();
        }

        /* Salva uma promocao */
        public int Save(Promocao promocao) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Promocoes.Add(promocao);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Save error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Atualiza uma promocao */
        public int Update(Promocao promocao) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Promocoes.Update(promocao);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Update error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Exclui uma promocao */
        public int Delete(Promocao promocao) {
            int rowsAffected = 0;
            try {
                context.ShowSQL(context);
                context.Promocoes.Remove(promocao);
                rowsAffected = context.SaveChanges();
                context.ShowEntityState(context);
                return rowsAffected;
            } catch (Exception e) {
                Debug.WriteLine("Delete error - " + e.Message);
                return rowsAffected;
            }
        }

        /* Busca uma promocao */
        public Promocao FindOne(int id) {
            try {
                context.ShowSQL(context);
                Promocao promocao = context.Promocoes.Find(id);
                context.ShowEntityState(context);
                return promocao;
            } catch (Exception e) {
                Debug.WriteLine("FindOne error - " + e.Message);
                return null;
            }
        }

        /* Busca todas as promocoes */
        public List<Promocao> FindAll() {
            try {
                context.ShowSQL(context);
                List<Promocao> promocoes = context.Promocoes.ToList();
                context.ShowEntityState(context);
                return promocoes;
            } catch (Exception e) {
                Debug.WriteLine("FindAll error - " + e.Message);
                return null;
            }
        }
    }
}
