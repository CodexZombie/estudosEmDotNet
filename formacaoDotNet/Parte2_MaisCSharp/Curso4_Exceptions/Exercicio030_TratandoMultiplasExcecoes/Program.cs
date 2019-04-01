using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio030_TratandoMultiplasExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
    /*        catch (DivideByZeroException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
    */
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Tentativa de divisão por zero.");
                throw;
            }
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            //Conta conta = null;
            //Console.WriteLine(conta.Saldo);
         
            Dividir(10, divisor);
        }


    }
}
