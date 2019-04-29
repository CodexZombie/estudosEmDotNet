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
            //ListaDeContaCorrente lista = TesteCriaListaDeContas();
            //TesteMetodoAdicionar(lista);
            //TesteMetodoRemover(lista);
            //TesteIndexador(lista);
            //TesteAdicionarVarios(lista);
            //lista.ListarContas();
            //lista.TestaListaDeObject();

            Lista<int> inteiros = new Lista<int>();
            inteiros.AdicionarVarios(1, 2, 3, 4, 5);
            inteiros.Adicionar("Amarelo");

            Lista<string> cores = new Lista<string>();
            cores.AdicionarVarios("Cyan", "Magenta", "Yellow", "Black");
            cores.Adicionar(10);


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

        static void TesteIndexador(ListaDeContaCorrente lista)
        {
            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} Ag/CC: {itemAtual.Agencia}/{itemAtual.Numero}");
            }
            Console.WriteLine();
        }

        static void TesteAdicionarVarios(ListaDeContaCorrente lista)
        {
            lista.AdicionarVarios(
                new ContaCorrente(999, 8888888),
                new ContaCorrente(999, 8888888),
                new ContaCorrente(999, 8888888),
                new ContaCorrente(999, 8888888),
                new ContaCorrente(999, 8888888)
                );
        }

        static void TesteListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar(8);
            listaDeIdades.AdicionarVarios(25, 13, 15, 14, 16, 17, 7, 6, 5, 4);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

    }
}
