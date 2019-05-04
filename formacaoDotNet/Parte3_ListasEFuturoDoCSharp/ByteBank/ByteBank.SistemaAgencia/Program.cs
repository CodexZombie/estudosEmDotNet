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

            List<int> idades = new List<int>();
            idades.AddRange(new int[] { 35, 24, 18, 17, 23 });

            idades.AdicionarVarios(40, 41, 43, 45, 42);

            for( int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
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
            lista.Adicionar(new ContaCorrente(123, 0000001));
            lista.Adicionar(new ContaCorrente(123, 0000002));
            lista.Adicionar(new ContaCorrente(123, 0000003));
            lista.Adicionar(new ContaCorrente(123, 0000004));
            lista.Adicionar(new ContaCorrente(123, 0000005));
            lista.Adicionar(new ContaCorrente(123, 0000006));
            lista.Adicionar(new ContaCorrente(123, 0000007));
        }

        static void TesteMetodoRemover(ListaDeContaCorrente lista)
        {
            ContaCorrente contaTesteRemocao = new ContaCorrente(999, 9999999);
            lista.Adicionar(contaTesteRemocao);
            lista.Adicionar(new ContaCorrente(123, 0000008));
            lista.Adicionar(new ContaCorrente(123, 0000009));
            lista.Adicionar(new ContaCorrente(123, 0000010));
            lista.Adicionar(new ContaCorrente(123, 0000011));
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

        static void TesteTipoGenerico()
        {
            Lista<int> inteiros = new Lista<int>();
            inteiros.AdicionarVarios(1, 2, 3, 4, 5);
            //inteiros.Adicionar("Amarelo");

            for (int i = 0; i < inteiros.Tamanho; i++)
            {
                int numeroAtual = inteiros[i];
            }

            Lista<string> cores = new Lista<string>();
            cores.AdicionarVarios("Cyan", "Magenta", "Yellow", "Black");
            //cores.Adicionar(10);
        }

    }
}
