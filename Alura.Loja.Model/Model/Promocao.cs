using System;
using System.Collections.Generic;

namespace Alura.Loja.Model.Model {

    public class Promocao {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public IList<PromocaoProduto> Produtos { get; set; }

        public Promocao() {

        }

        public Promocao(int Id, string Descricao, DateTime DataInicio, DateTime DataTermino) {
            this.Id = Id;
            this.Descricao = Descricao;
            this.DataInicio = DataInicio;
            this.DataTermino = DataTermino;
        }

        public override string ToString() {
            return $"Promocao: Id: {this.Id} | Descricao: {this.Descricao} | DataInicio: {this.DataInicio} | DataTermino: {this.DataTermino} | Produtos: {this.Produtos.ToString()}";
        }
    }
}
