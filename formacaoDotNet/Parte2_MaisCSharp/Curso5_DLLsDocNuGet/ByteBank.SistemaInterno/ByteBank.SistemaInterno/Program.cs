using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 1234567);
            conta.Sacar(50);

            Console.WriteLine(conta.Numero);
            
            Console.ReadLine();
        }
    }
}
