using ByteBank.Modelos;
using System;
using Humanizer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "pagina?modedaOrigem=real&moedaDestino=dolar";

            //TesteIsNullOrEmpty();
            TesteLengthESobrecargasDeIndexOf();

            Console.ReadLine();
        }

        static void TesteIsNullOrEmpty()
        {
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "asdfasdfasdf";

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));
        }

        static void TesteLengthESobrecargasDeIndexOf()
        {
            string palavra = "modedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
        }
    }
}
