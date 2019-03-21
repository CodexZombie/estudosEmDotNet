using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio005_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o exercicio 5 - Caracteres e Texto");

            //Character
            char letraChar = 'a'; //aspas simples
            Console.WriteLine("Primeira Letra: " + letraChar);

            letraChar = (char)65;
            Console.WriteLine("Letra '65': " + letraChar);
            Console.WriteLine("Letra '65' + 2: " + (char)(letraChar + 2));

            string frase = "Olá, eu sou uma string";
            Console.WriteLine(frase);

            Console.WriteLine(frase + ". Essa parte está concatenada.");


            Console.ReadLine();
        }
    }
}
