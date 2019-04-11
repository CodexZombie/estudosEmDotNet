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
            TestaClasseExtrator();
            Console.ReadLine();
        }

        static void TestaClasseExtrator()
        {
            string urlParametros = "http://www.bytebank.com.br/cambio?moedaOrigem=Real&moedaDestino=Dolar&Valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string termoBusca = extrator.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + termoBusca);

            termoBusca = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + termoBusca);

            termoBusca = extrator.GetValor("VAlor");
            Console.WriteLine("Valor: " + termoBusca);

        }
    }
}
