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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));

            ContaCorrente contaTesteRemocao = new ContaCorrente(999, 9999999);

            lista.Adicionar(contaTesteRemocao);
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            Console.WriteLine();


            lista.ListarContas();

            lista.Remover(contaTesteRemocao);

            Console.WriteLine();
            lista.ListarContas();

            Console.ReadLine();
        }
    }
}
