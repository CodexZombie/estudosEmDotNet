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

            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "asdfasdfasdf";

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

            Console.ReadLine();
        }
    }
}
