using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio029_ForcandoUmaExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Source);
                Console.WriteLine("Tratamento de Exceção: " + erro.Message);
            }

            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao( int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
