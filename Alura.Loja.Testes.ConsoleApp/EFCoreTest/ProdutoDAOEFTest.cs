using Alura.Loja.Testes.ConsoleApp.EFCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp.EFCoreTest {

    [TestClass]
    public class ProdutoDAOEFTest {

        private ProdutoDAOEF produtoDAO = new ProdutoDAOEF();

        [TestMethod]
        public void SaveTest() {
            int rowsAffected = produtoDAO.Save(new Produto(0, "Test", "Test", 19.90));
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void UpdateTest() {
            Produto produto = produtoDAO.FindOne(1);
            produto.Nome = "Ok";
            int rowsAffected = produtoDAO.Update(produto);
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void DeleteTest() {
            Produto produto = produtoDAO.FindOne(2007);
            int rowsAffected = produtoDAO.Delete(produto);
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void FindOneTest() {
            Produto produto = produtoDAO.FindOne(1);
            Assert.IsNotNull(produto);
        }

        [TestMethod]
        public void FindAllTest() {
            List<Produto> produtos = produtoDAO.FindAll();
            Assert.AreNotEqual(0, produtos.Count);
        }
    }
}
