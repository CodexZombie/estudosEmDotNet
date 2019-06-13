using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("=====================");
                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.State);
                }

                var p1 = produtos.Last();
                p1.Nome = "007 - O Espião Que Me Amava";

                Console.WriteLine("=====================");
                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.State);
                }

                //var p1 = produtos.First();
                //p1.Nome = "Harry Potter";
                //
                //contexto.SaveChanges();

                //produtos = contexto.Produtos.ToList();
                //
                //foreach (var p in produtos)
                //{
                //    Console.WriteLine(p);
                //}
            }

            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //    //GravarUsandoAdoNet();
        //    //GravarUsandoEntity();
        //    //RecuperarProdutos();
        //    //ExcluirProdutos();
        //    //RecuperarProdutos();
        //    //AtualizarProduto();
        //
        //
        //    Console.ReadLine();
        //}
        //
        //private static void AtualizarProduto()
        //{
        //    GravarUsandoEntity();
        //    RecuperarProdutos();
        //
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        Produto primeiro = repo.Produtos().First();
        //        primeiro.Nome = "Cassino Royale - Editado";
        //        repo.Atualizar(primeiro);
        //    }
        //    RecuperarProdutos();
        //}
        //
        //private static void ExcluirProdutos()
        //{
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        IList<Produto> produtos = repo.Produtos();
        //        foreach (var item in produtos)
        //        {
        //            repo.Remover(item);
        //        }
        //    }
        //}
        //
        //private static void RecuperarProdutos()
        //{
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        IList<Produto> produtos = repo.Produtos();
        //        Console.WriteLine("Foram Encontrados {0} produto(s).", produtos.Count);
        //        foreach (var item in produtos)
        //        {
        //            Console.WriteLine(item.Nome);
        //        }
        //    }
        //}
        //
        //static void GravarUsandoEntity()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Cassino Royale";
        //    p.Categoria = "Filmes";
        //    p.Preco = 19.89;
        //
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
        //
        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;
        //
        //    using (var repo = new ProdutoDAO())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
    }
}
