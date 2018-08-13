using Alura.Loja.Database.DAO;
using Alura.Loja.Model.Model;

namespace Alura.Loja.App {

    public class Program {

        private static void Main(string[] args) {
            CompraDAO compraDAO = new CompraDAO();
            Compra compra = new Compra();
            Produto pao = new Produto(0, "Pão Frances", "Padaria", 0.40, "UN");
            compra.Produto = pao;
            compra.Quantidade = 6;
            compra.Preco = (pao.PrecoUnidade * compra.Quantidade);
            compraDAO.Save(compra);
        }
    }
}
