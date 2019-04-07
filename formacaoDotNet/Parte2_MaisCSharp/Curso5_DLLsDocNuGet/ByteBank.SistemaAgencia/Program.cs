using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 1234567);

            new ContaCorrente(123, 456).Sacar(100);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
