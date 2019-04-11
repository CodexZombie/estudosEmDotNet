using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteToLowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);
            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));

            termoBusca = "ra";
            Console.WriteLine(termoBusca);

            Console.WriteLine(termoBusca.ToUpper());

            termoBusca = termoBusca.ToLower();
            mensagemOrigem = mensagemOrigem.ToLower();

            Console.WriteLine(termoBusca);
            Console.WriteLine(mensagemOrigem);
            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));

            Console.ReadLine();
        }
    }
}
