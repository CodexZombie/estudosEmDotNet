using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio033_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            Console.WriteLine(url.Substring(indiceInterrogacao));
            Console.WriteLine(url.Substring(indiceInterrogacao + 1));


            Console.ReadLine();
        }
    }
}
