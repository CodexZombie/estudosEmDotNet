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
            //TestaContaCorrente();

            DateTime dataFimPagto = new DateTime(2019, 05, 07);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagto - dataCorrente;

            string mensagem = TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(dataFimPagto);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        
        static void TestaContaCorrente()
        {
            ContaCorrente conta = new ContaCorrente(123, 1234567);

            new ContaCorrente(123, 456).Sacar(100);

            Console.WriteLine(conta.Numero);
        }
    }
}
