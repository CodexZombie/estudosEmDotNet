using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIsNullOrEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "asdfasdfasdf";

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));
        }
    }
}
