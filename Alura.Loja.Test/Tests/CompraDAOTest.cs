using Alura.Loja.Database.DAO;
using Alura.Loja.Model.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alura.Loja.Test.Tests {

    [TestClass]
    public class CompraDAOTest {

        private CompraDAO compraDAO = new CompraDAO();

        [TestMethod]
        public void SaveCompraTest() {
            Compra compra = new Compra();
            Produto pao = new Produto(0, "Pão Frances", "Padaria", 0.40, "UN");
            compra.Produto = pao;
            compra.Quantidade = 6;
            compra.Preco = (pao.PrecoUnidade * compra.Quantidade);
            int rowsAffected = compraDAO.Save(compra);
            Assert.AreNotEqual(0, rowsAffected);
        }

        [TestMethod]
        public void UpdateCompraTest() {
            Compra compra = compraDAO.FindOne(1);
            compra.Preco = 2.4;
            int rowsAffected = compraDAO.Update(compra);
            Assert.AreNotEqual(0, rowsAffected);
        }
    }
}
