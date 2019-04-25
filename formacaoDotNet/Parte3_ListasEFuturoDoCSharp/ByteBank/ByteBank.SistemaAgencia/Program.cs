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

            ListaDeContaCorrente lista = TesteCriaListaDeContas();
            TesteMetodoAdicionar(lista);
            TesteMetodoRemover(lista);


            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} Ag/CC: {itemAtual.Agencia}/{itemAtual.Numero}");
            }

            Console.ReadLine();
        }

        static ListaDeContaCorrente TesteCriaListaDeContas()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            return lista;
        }

        static void TesteMetodoAdicionar(ListaDeContaCorrente lista)
        {
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

        }

        static void TesteMetodoRemover(ListaDeContaCorrente lista)
        {
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
            Console.WriteLine();
        }
    }
}
