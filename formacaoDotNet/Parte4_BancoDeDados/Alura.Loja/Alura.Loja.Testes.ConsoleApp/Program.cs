using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;




namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using(var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                //contexto.Promocoes.Add(promocaoDePascoa);
                var promocao = contexto.Promocoes.Find(1);
                contexto.Promocoes.Remove(promocao);
                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }

            Console.ReadLine();
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("============================");
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }
    }
}
