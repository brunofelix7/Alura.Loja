using Alura.Loja.Model;
using System.Collections.Generic;

namespace Alura.Loja.DAO.Interface {

    interface IProdutoDAO {

        int Save(Produto produto);
        int Update(Produto produto);
        int Delete(Produto produto);
        Produto FindOne(int id);
        List<Produto> FindAll();

    }
}
