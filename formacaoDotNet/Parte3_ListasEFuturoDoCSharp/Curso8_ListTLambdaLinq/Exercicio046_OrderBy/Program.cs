using ClassesAuxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio046_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = Pessoa.GerarLista();
            
            Imprime(pessoas);

            IOrderedEnumerable<Pessoa> pessoasOrdenado;
            

            pessoasOrdenado = pessoas.OrderBy(pessoa => pessoa.Idade);

            ImprimeOrdenado(pessoasOrdenado, "Idade");
            //---> x => x.parametro é uma expressão lambda;
            //---> O Método OrderBy não trata referências nulas;
            //---> Ao se deparar com uma referência nula uma exceção de referência nula será lançada;
            //---> Como o método recebe uma expressão lambda, pode ser expandido para receber uma lógica expecífica.

            pessoasOrdenado = pessoas.OrderBy(pessoa => pessoa.Altura);
            ImprimeOrdenado(pessoasOrdenado, "Altura");

            pessoas.AddRange(new Pessoa[] { null, null, null });
            pessoasOrdenado = pessoas.OrderBy(pessoa =>
            {
                if (pessoa == null)
                {
                    return "zzzz";
                }
                return pessoa.Nome;
            });
            ImprimeOrdenado(pessoasOrdenado, "Nome");

            Console.ReadLine();
        }



        //##################################################################################
        //--- MÉTODOS AUXILIARES APENAS PARA FACILITAR A LEITURA DO BLOCO MAIN ---
        //##################################################################################

        public static void Imprime(List<Pessoa> lista)
        {
            Console.WriteLine($"Imprimindo a lista original de pessoas:");
            Console.WriteLine();
            foreach (var p in lista)
            {
                Console.WriteLine($"Idade: {p.Idade}, Altura: {p.Altura}, Nome: {p.Nome} ");
            }
            Console.WriteLine();
        }

        public static void ImprimeOrdenado(IOrderedEnumerable<Pessoa> lista, string ordenadoPor)
        {
            Console.WriteLine($"Imprimindo a lista de pessoas ordenada por {ordenadoPor}:");
            Console.WriteLine();
            foreach (var p in lista)
            {
                if (p == null)
                {
                    Console.WriteLine("Referência nula");
                }
                else
                {
                    Console.WriteLine($"Idade: {p.Idade}, Altura: {p.Altura}, Nome: {p.Nome} ");
                }
            }
            
            Console.WriteLine();
        }
    }
}
