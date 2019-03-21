using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio009_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o exercicio 9 - Escopo");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado = true;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
                // se a variavel tivesse sido declada aqui, não poderia ser utilizada após o bloco.
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }

            Console.ReadLine();
        }
    }
}
