using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio014_PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaPatricia = new ContaCorrente();

            contaDaPatricia.titular = "Patrícia";
            contaDaPatricia.agencia = 123;
            contaDaPatricia.numero = 12345;
            contaDaPatricia.saldo = 350;

            Console.WriteLine("Titular: " + contaDaPatricia.titular);
            Console.WriteLine("Agencia: " + contaDaPatricia.agencia);
            Console.WriteLine("Conta: " + contaDaPatricia.numero);
            Console.WriteLine("Saldo: " + contaDaPatricia.saldo);
            
            contaDaPatricia.saldo += 150;
            Console.WriteLine("Saldo: " + contaDaPatricia.saldo);

            Console.ReadLine();
        }
    }
}
