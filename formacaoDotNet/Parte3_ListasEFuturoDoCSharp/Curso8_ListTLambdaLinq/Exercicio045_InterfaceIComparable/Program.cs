using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio045_InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>()
            {
                new Pessoa("Bianca", 35),
                new Pessoa("Katia", 24),
                new Pessoa("Wilson", 18),
                new Pessoa("Pedro", 17),
                new Pessoa("Zélio", 23),
                new Pessoa("Selma", 40),
                new Pessoa("Helena", 41),
                new Pessoa("Maria", 43),
                new Pessoa("Auguto", 45),
                new Pessoa("José", 42)
            };

            foreach (var p in pessoas)
            {
                Console.WriteLine($"{p.Nome} {p.Idade}");
            }

            Console.WriteLine("Ordenando...");
            Console.WriteLine("LISTA ORDENADA:");
            Console.WriteLine();

            pessoas.Sort();

            foreach (var p in pessoas)
            {
                Console.WriteLine($"{p.Nome} {p.Idade}");
            }

            Console.ReadLine();
        }
    }
}
