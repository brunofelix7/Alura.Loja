using Alura.Loja.Model.Model;
using System.Collections.Generic;

namespace Alura.Loja.Database.Interface {

    interface ICompraDAO {

        int Save(Compra compra);
        int Update(Compra compra);
        int Delete(Compra compra);
        Compra FindOne(int id);
        List<Compra> FindAll();

    }
}
