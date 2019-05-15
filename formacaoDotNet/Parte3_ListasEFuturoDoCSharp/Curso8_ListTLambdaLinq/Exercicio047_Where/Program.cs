using ClassesAuxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio047_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = Pessoa.GerarLista();

            pessoas.AddRange(new Pessoa[] {null, null, null });
            // Causa erro de referência nula no foreach

            var listaSemNulos = pessoas.Where(p => p != null);
            // "listaSemNulos" recebe de "pessoas"."Onde" cada "p" for diferente de nulo;
            // Assim, a lista poderá ser interada e exibida sem problemas;

            var listaOrdenada = listaSemNulos.OrderBy(p => p.Idade);
            // Retorna um objeto ordenado após a remoção dos elementos nulos;

            var lista = pessoas
                .Where(p => p != null)
                .OrderBy(p => p.Idade)
                .Where(p => p.Idade < 40);
            // A sentença pode ser declarada de forma encadeada obedecendo a vários critérios

            foreach (var p in lista)
            {
                Console.WriteLine($"{p.Idade} {p.Altura} {p.Nome}");
            }

            Console.ReadLine();
        }
    }
}
