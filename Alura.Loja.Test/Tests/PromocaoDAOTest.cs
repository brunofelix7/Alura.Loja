using Alura.Loja.Model.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Alura.Loja.Test.Tests {

    [TestClass]
    public class PromocaoDAOTest {

        [TestMethod]
        public void SavePromocaoTest() {
            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            //promocaoDePascoa.Produtos.Add(new Produto());
            //promocaoDePascoa.Produtos.Add(new Produto());
            //promocaoDePascoa.Produtos.Add(new Produto());
        }
    }
}
