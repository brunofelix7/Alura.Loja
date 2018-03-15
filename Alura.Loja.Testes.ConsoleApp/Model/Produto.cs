namespace Alura.Loja.Testes.ConsoleApp {

    internal class Produto {

        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double Preco { get; internal set; }

        public Produto() {

        }

        public Produto(int Id, string Nome, string Categoria, double Preco) {
            this.Id = Id;
            this.Nome = Nome;
            this.Categoria = Categoria;
            this.Preco = Preco;
        }

    }
}