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
            var pessoas = GerarLista();
            
            Imprime(pessoas);
            
            var pessoasOrdenado = pessoas.OrderBy(Pessoa => Pessoa.Idade);
            ImprimeOrdenado(pessoasOrdenado, "Idade");
            
            pessoasOrdenado = pessoas.OrderBy(Pessoa => Pessoa.Altura);
            ImprimeOrdenado(pessoasOrdenado, "Altura");

            pessoasOrdenado = pessoas.OrderBy(Pessoa => Pessoa.Nome);
            ImprimeOrdenado(pessoasOrdenado, "Nome");

            Console.ReadLine();
        }



        //##################################################################################
        //--- MÉTODOS E CLASSES AUXILIARES APENAS PARA FACILITAR A LEITURA DO BLOCO MAIN ---
        //##################################################################################

        
        public static List<Pessoa> GerarLista()
        {
            return new List<Pessoa>()
            {
                new Pessoa(idade: 35, altura: 1.81, nome: "Bianca"),
                new Pessoa(idade: 24, altura: 1.77, nome: "Katia"),
                new Pessoa(idade: 18, altura: 1.76, nome: "Wilson"),
                new Pessoa(idade: 17, altura: 1.78, nome: "Pedro"),
                new Pessoa(idade: 23, altura: 1.75, nome: "Zélio"),
                new Pessoa(idade: 40, altura: 1.61, nome: "Selma"),
                new Pessoa(idade: 41, altura: 1.68, nome: "Helena"),
                new Pessoa(idade: 43, altura: 1.65, nome: "Maria"),
                new Pessoa(idade: 45, altura: 1.71, nome: "Auguto"),
                new Pessoa(idade: 42, altura: 1.91, nome: "José")
            };
        }

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
                Console.WriteLine($"Idade: {p.Idade}, Altura: {p.Altura}, Nome: {p.Nome} ");
            }
            Console.WriteLine();
        }
    }

    public class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }
        public double Altura { get; }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }
}
