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

            //SYNTAX SUGAR PARA ARRAYS:
            bool[] arrayDeBooleanos = new bool[]
            {
                true,
                false,
                true,
                false,
                true,
            };
            TestaArray(arrayDeBooleanos);

            CalculaMedia(idades);

            //SYNTAX SUGAR PARA ARRAYS:
            string[] coresCMYK = new string[]
            {
                "Cyan",
                "Magenta",
                "Yellow",
                "blacK",
            };

            TestaArray(coresCMYK);

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

        static void TestaArray(string[] array)
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
            Console.WriteLine();
        }
    }
}
