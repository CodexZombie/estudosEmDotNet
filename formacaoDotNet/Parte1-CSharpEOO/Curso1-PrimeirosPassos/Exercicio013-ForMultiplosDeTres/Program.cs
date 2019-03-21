using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio013_ForMultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 100; x++)
            {
                // se x % 3 = 0 --> X é multiplo de 3
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }

            }

            // OU
            Console.WriteLine();

            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
