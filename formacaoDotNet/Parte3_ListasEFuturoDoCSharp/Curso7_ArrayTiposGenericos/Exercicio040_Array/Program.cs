using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio040_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            TestaArray(idades);


            int[] testeValorPadrao = new int[5];
            TestaArray(testeValorPadrao);

            //Lança exceção de Referência Nula
            //int[] testeAtribuicaoNula = null;
            //TestaArray(testeAtribuicaoNula);

            bool[] arrayDeBooleanos = new bool[5];
            arrayDeBooleanos[0] = true;
            arrayDeBooleanos[1] = false;
            arrayDeBooleanos[2] = true;
            arrayDeBooleanos[3] = false;
            arrayDeBooleanos[4] = true;
            TestaArray(arrayDeBooleanos);

            CalculaMedia(idades);

            Console.ReadLine();
        }


        static void TestaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Posição {i} = {array[i]}");
            }
            Console.WriteLine();
        }

        static void TestaArray(bool[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Posição {i} = {array[i]}");
            }
            Console.WriteLine();
        }

        static void CalculaMedia(int[] array)
        {
            int acumulador = 0;

            for (int i = 0; i < array.Length; i++)
            {
                acumulador += array[i];
            }

            float media = acumulador / array.Length;
            Console.WriteLine($"Média das idades = {media}");
        }
    }
}
