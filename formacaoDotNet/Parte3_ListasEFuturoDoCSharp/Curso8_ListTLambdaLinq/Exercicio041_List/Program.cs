using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio041_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe List
            //Recebe o tipo dentro do <>
            List<int> numeros = new List<int>();

            //Método Adicionar .Add()
            //Recebe os valores individualmente e adiciona como último elemento da lista.
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);

            //Método auxiliar para percorrer a lista e obter os valores armazenados em cada posição.
            ImprimeItensDaLista(numeros);

            //Método para adicionar vários elementos .AddRange()
            //Recebe uma coleção (lista) como argumento
            int[] colecao = new int[] { 5, 6, 7, 8, 9 };
            numeros.AddRange(colecao);
            ImprimeItensDaLista(numeros);

            //Declarando e atribuindo a coleção diretamente no construtor
            numeros.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });
            ImprimeItensDaLista(numeros);


            //Método para remover itens da lista .Remove
            numeros.Remove(9);
            ImprimeItensDaLista(numeros);

            //Remover Vários .RemoveRange(i, c)
            //i = indice onde deve começar a remoção
            //c = quantidade de itens a serem removidos a partir do indice
            numeros.RemoveRange(5, 3);
            ImprimeItensDaLista(numeros);


            List<string> letras = new List<string>();
            letras.AddRange(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" });
            ImprimeItensDaLista(letras);

            letras.RemoveRange(5, 5);
            ImprimeItensDaLista(letras);

            Console.ReadLine();
        }

        static void ImprimeItensDaLista(List<int> lista)
        {
            Console.WriteLine();
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

        static void ImprimeItensDaLista(List<string> lista)
        {
            Console.WriteLine();
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

    }
}
