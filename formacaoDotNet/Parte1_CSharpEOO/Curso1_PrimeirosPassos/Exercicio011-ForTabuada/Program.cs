using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio011_ForTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
            {
                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    int produto = multiplicando * multiplicador;
                    Console.WriteLine(multiplicando + " x " + multiplicador + " = " + produto);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
