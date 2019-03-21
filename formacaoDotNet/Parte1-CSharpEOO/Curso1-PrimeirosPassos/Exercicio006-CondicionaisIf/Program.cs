using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio006_CondicionaisIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o exercicio 6 - Condicionais If");

            int idadeJoao = 16;
            int qtdPessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João tem mais de 18 anos. Pode Entrar.");
            }
            else
            {
                if (qtdPessoas >= 2)
                {
                    Console.WriteLine("João não tem mais de 18 anos mas está acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("João NÂO tem mais de 18 anos. Não pode entrar.");
                }

            }

            Console.ReadLine();
        }
    }
}
