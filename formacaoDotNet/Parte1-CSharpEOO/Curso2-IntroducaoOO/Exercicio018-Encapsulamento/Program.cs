using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio018_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente joao = new Cliente();
            joao.Nome = "João";
            joao.CPF = "123.456.789.10";
            joao.Profissao = "Programador";
            
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = joao;
            Console.WriteLine("Titular: " + conta.Titular.Nome);

            Console.WriteLine("Saldo inicial: " + conta.Saldo);

            conta.Saldo = -150;

            Console.WriteLine("Tentando atribuir -150 ao saldo: " + conta.Saldo);

            conta.Saldo = 500;

            Console.WriteLine("Tentando atribuir 500 ao saldo: " + conta.Saldo);

            Console.ReadLine();
        }
    }
}
