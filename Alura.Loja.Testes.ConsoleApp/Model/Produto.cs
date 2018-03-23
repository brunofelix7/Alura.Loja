namespace Alura.Loja.Testes.ConsoleApp {

    public class Produto {

        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnidade { get; internal set; }
        public int Unidade { get; internal set; }

        public Produto() {

        }

        public Produto(int Id, string Nome, string Categoria, double PrecoUnidade) {
            this.Id = Id;
            this.Nome = Nome;
            this.Categoria = Categoria;
            this.PrecoUnidade = PrecoUnidade;
        }

        public override string ToString() {
            return $"Produto: Id: {this.Id} | Nome: {this.Nome} | Categoria: {this.Categoria} | Preco: {this.PrecoUnidade}";
        }
    }
}