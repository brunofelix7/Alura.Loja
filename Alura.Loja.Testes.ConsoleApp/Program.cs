using System.Collections.Generic;
using System.Diagnostics;

namespace Alura.Loja.Testes.ConsoleApp {

    class Program {

        static void Main(string[] args) {
            //  Call methods
        }

        private static void Add() {
            var produto = new Produto(0, "Harry Potter e a Ordem da Fênix", "Livros", 19.89);
            var produtoDAO = new ProdutoDAO();
            produtoDAO.Save(produto);
        }

        private static void Update() {
            var produto = new Produto(1, "Harry Potter e a Ordem da Fênix", "Livros", 29.90);
            var produtoDAO = new ProdutoDAO();
            produtoDAO.Update(produto);
        }

        private static void Remove() {
            var produto = new Produto(1, "Harry Potter e a Ordem da Fênix", "Livros", 29.90);
            var produtoDAO = new ProdutoDAO();
            produtoDAO.Remove(produto);
        }

        private static void List() {
            var produtoDAO = new ProdutoDAO();
            List<Produto> produtos = produtoDAO.FindAll();
            foreach(Produto produto in produtos) {
                Debug.WriteLine(produto.Nome);
                Debug.WriteLine(produto.Categoria);
                Debug.WriteLine(produto.Preco);
            }
        }
    }
}
