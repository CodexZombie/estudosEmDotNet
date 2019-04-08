using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio032_MontandoUmaURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";

            string argumentos = url.Substring(7);

            Console.WriteLine(url);
            Console.WriteLine(argumentos);

            string arg1 = "cambio";
            string arg2 = "valor=1500";
            string arg3 = "moedaOrigem=real";
            string arg4 = "moedaDestino=dolar";

            url = "www.bytebank.com.br/";
            argumentos = arg1 + "?" + arg2 + "&" + arg3 + "&" + arg4;

            Console.WriteLine(url + argumentos);

            Console.ReadLine();

        }


    }
}
