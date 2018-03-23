namespace Alura.Loja.Model {

    public class Compra {

        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public Compra() {

        }

        public Compra(int Id, int Quantidade, double Preco, Produto Produto) {
            this.Id = Id;
            this.Quantidade = Quantidade;
            this.Preco = Preco;
            this.Produto = Produto;
        }

        public override string ToString() {
            return $"Compra: Id: {this.Id} | Quantidade: {this.Quantidade} | Preco: {this.Preco} | Produto: {this.Produto.ToString()}";
        }

    }
}
