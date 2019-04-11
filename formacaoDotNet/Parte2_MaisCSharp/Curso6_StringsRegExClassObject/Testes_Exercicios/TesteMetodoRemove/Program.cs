using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMetodoRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string testeRemove = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemove.IndexOf('&');

            string aposRemocao = testeRemove.Remove(indiceEComercial);
            Console.WriteLine(aposRemocao);

            //Erro quando não encontra o valor procurado:
            string texto = "ABCDE";
            Console.WriteLine(texto.IndexOf('F'));
        }
    }
}
