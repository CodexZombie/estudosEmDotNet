using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio044_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string>()
            {
                "Bianca", "Katia", "Wilson", "Pedro", "Zélio",
                "Selma", "Helena", "Maria", "Auguto", "José"
            };

            var idades = new List<int>()
            {
               35, 24, 18, 17, 23, 40, 41, 43, 45, 42
            };

            Imprime(nomes);
            Imprime(idades);

            Console.WriteLine("Ordenando...");
            Console.WriteLine("LISTA ORDENADA:");
            Console.WriteLine();

            nomes.Sort();
            idades.Sort();

            Imprime(nomes);
            Imprime(idades);

            Console.ReadLine();
        }

        static void Imprime<T>(List <T> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
