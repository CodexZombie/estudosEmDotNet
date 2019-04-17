using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[3];

            contas[0] = new ContaCorrente(123, 1234567);
            contas[1] = new ContaCorrente(123, 1234568);
            contas[2] = new ContaCorrente(123, 1234569);

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente conta = contas[i];
                Console.WriteLine($"Conta {i} Agência {conta.Agencia} Número {conta.Numero}");
            }

            Console.ReadLine();
        }
    }
}
