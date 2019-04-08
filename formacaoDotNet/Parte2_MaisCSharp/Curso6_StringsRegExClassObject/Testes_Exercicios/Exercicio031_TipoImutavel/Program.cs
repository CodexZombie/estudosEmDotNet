using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio031_TipoImutavel
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";
            Console.WriteLine("string url = \"pagina?argumentos\";");
            Console.WriteLine(url + "\n");

            url.Substring(6);
            Console.WriteLine("url.Substring(6);");
            Console.WriteLine(url + "\n");

            string argumentos = url.Substring(6);
            Console.WriteLine("string argumentos = url.Substring(6);");
            Console.WriteLine(argumentos + "\n");

            url += "sufixo";
            Console.WriteLine("url += \"sufixo\";");
            Console.WriteLine(url);
            Console.WriteLine(argumentos + "\n");

            string temp = url += "sufixo";
            Console.WriteLine("string temp = url += \"sufixo\";");
            Console.WriteLine(temp + "\n");

            Console.ReadLine();
        }
    }
}
