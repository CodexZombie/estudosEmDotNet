using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteStartsWithEndsWithContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlTeste = "https://www.meusite.com/umapagina";

            Console.WriteLine(urlTeste.StartsWith("https://www.meusite.com"));
            Console.WriteLine(urlTeste.StartsWith("https://www.google.com"));

            Console.WriteLine(urlTeste.Contains("meusite"));
            Console.WriteLine(urlTeste.Contains("MEUSITE"));

            Console.WriteLine(urlTeste.EndsWith("umapagina"));
            Console.WriteLine(urlTeste.EndsWith("umapagina/"));

            Console.ReadLine();
        }
    }
}
