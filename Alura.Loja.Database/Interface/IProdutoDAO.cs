using Alura.Loja.Model.Model;
using System.Collections.Generic;

namespace Alura.Loja.Database.Interface {

    interface IProdutoDAO {

        int Save(Produto produto);
        int Update(Produto produto);
        int Delete(Produto produto);
        Produto FindOne(int id);
        List<Produto> FindAll();

    }
}
