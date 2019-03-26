using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio010_WhileEFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo usando o While:");
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("Imprimindo usando o for:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
