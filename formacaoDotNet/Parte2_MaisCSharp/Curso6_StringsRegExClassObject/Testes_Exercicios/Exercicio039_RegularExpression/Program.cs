using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio039_RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoDeTeste = "Olá, meu nome é José e meu telefone é 4675-3041.";

            string padrao = "[0123456789][0123456789][0123456789][0123456789]" +
                "[-][0123456789][0123456789][0123456789][0123456789]";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultadoTeste = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultadoTeste.Value);


            textoDeTeste = "3778-1669 é o novo numero e está em outro lugar.";
            padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            resultadoTeste = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultadoTeste.Value);

            padrao = "[0-9]{4}[-][0-9]{4}";
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            resultadoTeste = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultadoTeste.Value);

            Console.ReadLine();
        }
    }
}
