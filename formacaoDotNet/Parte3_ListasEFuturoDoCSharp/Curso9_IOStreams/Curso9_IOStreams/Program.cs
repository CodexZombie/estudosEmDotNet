﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso9_IOStreams
{
    // Exercicio 048 - FileStream
    class Program
    {
        static void Main(string[] args)
        {
            var arquivoURL = "D:\\estudosEmDotNet\\formacaoDotNet\\Parte3_ListasEFuturoDoCSharp\\Curso9_IOStreams\\contas.txt";

            var fluxoDoArquivo = new FileStream(arquivoURL, FileMode.Open);

            var buffer = new byte[1024]; // 1 kb
            var bytesLidos = -1;

            fluxoDoArquivo.Read(buffer, 0, 1024);

            while (bytesLidos != 0)
            {
                bytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var b in buffer)
            {
                Console.Write(b);
                Console.Write(" ");
            }
        }
    }
}
