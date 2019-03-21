using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio015_TiposReferenciaEValor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipo de Referencia
            ContaCorrente contaDaPatricia = new ContaCorrente();
            contaDaPatricia.titular = "Patricia";
            contaDaPatricia.agencia = 123;
            contaDaPatricia.numero = 12345;
            contaDaPatricia.saldo = 200;

            ContaCorrente contaDaPatricia2 = new ContaCorrente();
            contaDaPatricia2.titular = "Patricia";
            contaDaPatricia2.agencia = 123;
            contaDaPatricia2.numero = 12345;
            contaDaPatricia2.saldo = 200;

            Console.WriteLine("Igualdade de tipo de Referência: " + (contaDaPatricia == contaDaPatricia2));

            // Tipo de Valor
            int numeroQualquer = 18;
            int outroNumero = 18;

            Console.WriteLine("Igualdade de tipo de valor: " + (numeroQualquer == outroNumero));


            contaDaPatricia = contaDaPatricia2;

            Console.WriteLine("Igualdade de tipo de Referência: " + (contaDaPatricia == contaDaPatricia2));

            Console.WriteLine("Saldo das contas 1 e 2: " + contaDaPatricia.saldo + " " + contaDaPatricia2.saldo);

            contaDaPatricia.saldo = 500;

            Console.WriteLine("Saldo das contas 1 e 2 após alterar o saldo da conta 1: "
                + contaDaPatricia.saldo + " " + contaDaPatricia2.saldo);

            Console.ReadLine();
        }
    }
}
