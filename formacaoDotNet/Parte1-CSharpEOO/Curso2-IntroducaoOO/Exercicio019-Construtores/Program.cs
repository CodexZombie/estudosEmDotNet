using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio019_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 1234567);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Agencia: " + conta.Agencia + " Agencia: " + conta.Numero);
            Console.WriteLine();

            ContaCorrente conta2 = new ContaCorrente(123, 2345678);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Agencia: " + conta2.Agencia + " Agencia: " + conta2.Numero);
            Console.WriteLine();

            ContaCorrente conta3 = new ContaCorrente(123, 3456789);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Agencia: " + conta3.Agencia + " Agencia: " + conta3.Numero);

            Console.ReadLine();
        }
    }
}
