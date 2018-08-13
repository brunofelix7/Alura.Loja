using Alura.Loja.Model.Model;
using System.Collections.Generic;

namespace Alura.Loja.Database.Interface {

    interface IPromocaoDAO {

        int Save(Promocao promocao);
        int Update(Promocao promocao);
        int Delete(Promocao promocao);
        Promocao FindOne(int id);
        List<Promocao> FindAll();
    }
}
