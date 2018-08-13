namespace Alura.Loja.Model.Model {

    public class PromocaoProduto {

        public int ProdutoId { get; set; }
        public int PromocaoId { get; set; }
        public Produto Produto { get; set; }
        public Promocao Promocao { get; set; }

        public PromocaoProduto() {

        }
    }
}
