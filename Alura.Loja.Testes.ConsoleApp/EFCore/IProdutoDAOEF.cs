using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp.EFCore {

    interface IProdutoDAOEF {

        int Save(Produto produto);
        int Update(Produto produto);
        int Delete(Produto produto);
        Produto FindOne(int id);
        List<Produto> FindAll();

    }
}
