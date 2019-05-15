using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio048_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 048 - FILESTREAM
            
            var arquivoURL = "../../../contas.txt";
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
