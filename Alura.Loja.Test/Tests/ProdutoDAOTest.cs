using Alura.Loja.Database.DAO;
using Alura.Loja.Model.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Alura.Loja.Test.Tests {

    [TestClass]
    public class ProdutoDAOTest {

        private ProdutoDAO produtoDAO = new ProdutoDAO();

        [TestMethod]
        public void SaveProdutoTest() {
            int rowsAffected = produtoDAO.Save(new Produto(0, "Test", "Test", 19.90, "UN"));
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void UpdateProdutoTest() {
            Produto produto = produtoDAO.FindOne(1);
            produto.Nome = "OK";
            int rowsAffected = produtoDAO.Update(produto);
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void DeleteProdutoTest() {
            Produto produto = produtoDAO.FindOne(1);
            int rowsAffected = produtoDAO.Delete(produto);
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void FindOneProdutoTest() {
            Produto produto = produtoDAO.FindOne(2);
            Assert.IsNotNull(produto);
        }

        [TestMethod]
        public void FindAllProdutoTest() {
            List<Produto> produtos = produtoDAO.FindAll();
            Assert.AreNotEqual(0, produtos.Count);
        }
    }
}
