using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio017_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente patricia = new Cliente();
            ContaCorrente contaDaPatricia = new ContaCorrente();

            patricia.nome = "Patricia";
            patricia.cpf = "123.456.789-10";
            patricia.profissao = "Corretora de Valores";

            contaDaPatricia.titular = patricia;
            contaDaPatricia.agencia = 123;
            contaDaPatricia.numero = 123456;
            contaDaPatricia.saldo = 15000.0;

            Console.WriteLine(patricia.nome);
            Console.WriteLine(contaDaPatricia.titular.nome);

            Console.ReadLine();
        }
    }
}
