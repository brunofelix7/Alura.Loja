using Alura.Loja.Testes.ConsoleApp.EFCore;

namespace Alura.Loja.Testes.ConsoleApp {

    public class Program {

        private static void Main(string[] args) {
            //  Call methods
            SaveEFC();
        }

        private static void SaveEFC() {
            var context = new LojaContext();
            context.Produtos.Add(new Produto(0, "Linkin Park - One More Light", "CDs e DVDs", 39.90));
            //  context.Produtos.AddRange(p1, p2, p3);
            context.SaveChanges();
        }
    }
}
