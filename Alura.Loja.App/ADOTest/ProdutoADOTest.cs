using Alura.Loja.App.ADO;
using Alura.Loja.Model.Model;
using System.Collections.Generic;
using System.Diagnostics;

namespace Alura.Loja.App.ADOTest {

    public class ProdutoDAOTest {

        private static ProdutoADO produtoDAO;

        public ProdutoDAOTest() {
            produtoDAO = new ProdutoADO();
        }

        public static void Add() {
            var produto = new Produto(0, "Harry Potter e a Ordem da Fênix", "Livros", 19.89, "UN");
            produtoDAO.Save(produto);
        }

        public static void Update() {
            var produto = new Produto(1, "Harry Potter e a Ordem da Fênix", "Livros", 29.90, "UN");
            produtoDAO.Update(produto);
        }

        public static void Remove() {
            var produto = new Produto(1, "Harry Potter e a Ordem da Fênix", "Livros", 29.90, "UN");
            produtoDAO.Remove(produto);
        }

        public static void List() {
            var produtoDAO = new ProdutoADO();
            List<Produto> produtos = produtoDAO.FindAll();
            foreach (Produto produto in produtos) {
                Debug.WriteLine(produto.Nome);
                Debug.WriteLine(produto.Categoria);
                Debug.WriteLine(produto.PrecoUnidade);
            }
        }
    }
}
