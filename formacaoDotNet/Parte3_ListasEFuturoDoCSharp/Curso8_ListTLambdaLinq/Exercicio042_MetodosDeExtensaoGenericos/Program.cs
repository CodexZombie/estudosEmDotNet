using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio042_MetodosDeExtensaoGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AdicionarVarios<int>(1, 2, 3, 4, 5);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }


            List<string> letras = new List<string>();
            letras.AdicionarVarios<string>("a", "b", "c", "d", "e");

            for (int i = 0; i < letras.Count; i++)
            {
                Console.WriteLine(letras[i]);
            }



            Console.ReadLine();
        }
    }
}
