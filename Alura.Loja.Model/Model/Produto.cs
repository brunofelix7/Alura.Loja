namespace Alura.Loja.Model {

    public class Produto {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnidade { get; set; }
        public string Unidade { get; set; }

        public Produto() {

        }

        public Produto(int Id, string Nome, string Categoria, double PrecoUnidade, string Unidade) {
            this.Id = Id;
            this.Nome = Nome;
            this.Categoria = Categoria;
            this.PrecoUnidade = PrecoUnidade;
            this.Unidade = Unidade;
        }

        public override string ToString() {
            return $"Produto: Id: {this.Id} | Nome: {this.Nome} | Categoria: {this.Categoria} | Preco: {this.PrecoUnidade}";
        }
    }
}