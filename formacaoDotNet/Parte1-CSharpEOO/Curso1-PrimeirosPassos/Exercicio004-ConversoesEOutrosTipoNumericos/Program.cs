using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio004_ConversoesEOutrosTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o exrecicio 4 - Conversoes e outro tipos numericos");

            double salarioDouble = 5650.5;

            Console.WriteLine("5650.5 em double " + salarioDouble);

            int salarioInt = (int)salarioDouble;

            Console.WriteLine("5650.5 convertido para int " + salarioInt);

            short numShort = 10000;
            int numInt = 1000000000;
            long numLong = 1000000000000000000;
            float numFloat = 1.80f;

            Console.ReadLine();
        }
    }
}
