using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio003_VarPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o exercicio 3 - Criando Variaveis com Ponto Flutuante");



            double salarioDouble = 5700.57;

            Console.WriteLine("5700.57 em um tipo Double: " + salarioDouble);

            salarioDouble = 5700.50;

            Console.WriteLine("5700.50 em um tipo Double: " + salarioDouble);


            int numeroInt = 15 / 2;

            Console.WriteLine("15 / 2 em um tipo int: " + numeroInt);

            double numeroDouble = 15 / 2;

            Console.WriteLine("15 / 2 em um tipo double: " + numeroDouble);

            numeroDouble = 15.0 / 2;

            Console.WriteLine("(15.0 / 2) em um tipo double: " + numeroDouble);


            Console.ReadLine();
        }
    }
}
