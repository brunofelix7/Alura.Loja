using System.Collections.Generic;
using System.Diagnostics;

namespace Alura.Loja.Testes.ConsoleApp.DAOTest {

    public class ProdutoDAOTest {

        private static ProdutoDAO produtoDAO;

        public ProdutoDAOTest() {
            produtoDAO = new ProdutoDAO();
        }

        public static void Add() {
            var produto = new Produto(0, "Harry Potter e a Ordem da Fênix", "Livros", 19.89);
            produtoDAO.Save(produto);
        }

        public static void Update() {
            var produto = new Produto(1, "Harry Potter e a Ordem da Fênix", "Livros", 29.90);
            produtoDAO.Update(produto);
        }

        public static void Remove() {
            var produto = new Produto(1, "Harry Potter e a Ordem da Fênix", "Livros", 29.90);
            produtoDAO.Remove(produto);
        }

        public static void List() {
            var produtoDAO = new ProdutoDAO();
            List<Produto> produtos = produtoDAO.FindAll();
            foreach (Produto produto in produtos) {
                Debug.WriteLine(produto.Nome);
                Debug.WriteLine(produto.Categoria);
                Debug.WriteLine(produto.PrecoUnidade);
            }
        }
    }
}
