using Alura.Loja.Testes.ConsoleApp.EFCore;

namespace Alura.Loja.Testes.ConsoleApp {

    public class Program {

        private static void Main(string[] args) {
            ProdutoDAOEF produtoDAO = new ProdutoDAOEF();
            produtoDAO.FindAll();
        }
    }
}
