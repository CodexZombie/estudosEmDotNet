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
            /* SIMPLIFICAÇÃO DAS REGEX
             * Padrão inicial: 
             * [0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]
             * [0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]
             * [0-9]{4}[-][0-9]{4}
             * [0-9]{4,5}[-]{0,1}[0-9]{4}
             * [0-9]{4,5}-{0,1}[0-9]{4}
             * [0-9]{4,5}-?[0-9]{4}
             *  
             * */

            string textoDeTeste = "Exemplo 1: Telefone 3572-2080";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            TestaRegex(textoDeTeste, padrao);
            
            textoDeTeste = "Exemplo 2: 37781669 é outro numero, em outro lugar e sem hifem.";
            TestaRegex(textoDeTeste, padrao);

            textoDeTeste = "Exemplo 3: Número de Celular 99532-2049.";
            TestaRegex(textoDeTeste, padrao);

            textoDeTeste = "Exemplo 3: Número de Celular sem hífem 995322080.";
            TestaRegex(textoDeTeste, padrao);

            textoDeTeste = "Exercício CPF: 123.456.789.10";
            padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}.?[0-9]{2}";
            TestaRegex(textoDeTeste, padrao);

            textoDeTeste = "Exercício CPF: 123.456.789-10";
            padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}.?[0-9]{2}";
            TestaRegex(textoDeTeste, padrao);

            textoDeTeste = "Exercício CPF: 123456789-10";
            padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}.?[0-9]{2}";
            TestaRegex(textoDeTeste, padrao);

            textoDeTeste = "Exercício CPF: 12345678910";
            padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}.?[0-9]{2}";
            TestaRegex(textoDeTeste, padrao);

            Console.ReadLine();
        }

        static void TestaRegex(string teste, string regex)
        {
            Console.WriteLine("String: " + teste);
            Console.WriteLine("Regex: " + regex);
            Console.WriteLine("Regex.IsMatch(): " + Regex.IsMatch(teste, regex));
            Match resultadoTeste = Regex.Match(teste, regex);
            Console.WriteLine("Saída para match.Value: " + resultadoTeste.Value);
            Console.WriteLine();
        }
    }
}
