using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio016_Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJoao = new ContaCorrente();
            contaDoJoao.saldo = 0;
            Console.WriteLine("Saldo atual: " + contaDoJoao.saldo);

            contaDoJoao.Depositar(100);

            Console.WriteLine("Saldo atual: " + contaDoJoao.saldo);

            bool resultadoSaque = contaDoJoao.Sacar(50);

            if(resultadoSaque)
            {
                Console.WriteLine("Saque Realizado com Sucesso.");
                Console.WriteLine("Saldo atual: " + contaDoJoao.saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                Console.WriteLine("Saldo atual: " + contaDoJoao.saldo);
            }


            ContaCorrente contaDaMaria = new ContaCorrente();
            Console.WriteLine();
            Console.WriteLine("Saldos iniciais");
            Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);
            Console.WriteLine("Saldo do joão: " + contaDoJoao.saldo);
            Console.WriteLine();


            Console.WriteLine("Transferencia de João para Maria - Cenario de sucesso");
            contaDoJoao.Transferir(25, contaDaMaria);
            Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);
            Console.WriteLine("Saldo do joão: " + contaDoJoao.saldo);
            Console.WriteLine();


            Console.WriteLine("Transferencia de João para Maria - Cenario de fracasso");
            contaDoJoao.Transferir(100, contaDaMaria);
            Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);
            Console.WriteLine("Saldo do joão: " + contaDoJoao.saldo);
            

            Console.ReadLine();
        }
    }
}
