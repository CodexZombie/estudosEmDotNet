using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio043_TipoImplicitoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração Explicita:
            int intE = 15;
            string textoE = "sdlfjaisdfjl";
            double doubleE = 1.5;

            // Declaração Implicita:
            var intI = 10;
            var textoI = "sdlfjaisdfjl";
            var doubleI = 1.5;

            Object[] lista = new Object[]
            {
                intE, intI, textoE, textoI, doubleE, doubleI
            };

            foreach (var item in lista)
            {
                ImprimeTipo(item);
            }


            Console.ReadLine();
        }

        static void ImprimeTipo(object variavel)
        {
            Console.WriteLine(variavel.GetType());
        }
    }
}
