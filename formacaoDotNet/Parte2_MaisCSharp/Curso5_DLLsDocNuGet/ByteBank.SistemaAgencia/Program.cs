using ByteBank.Modelos;
using System;
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

            DateTime dataFimPagto = new DateTime(2019, 08, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagto - dataCorrente;
            

            Console.WriteLine(dataFimPagto);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(GetIntervaloDeTempoLegivel(diferenca));

            Console.ReadLine();
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            return timeSpan.Days + " dias.";
        }

        static void TestaContaCorrente()
        {
            ContaCorrente conta = new ContaCorrente(123, 1234567);

            new ContaCorrente(123, 456).Sacar(100);

            Console.WriteLine(conta.Numero);
        }
    }
}
