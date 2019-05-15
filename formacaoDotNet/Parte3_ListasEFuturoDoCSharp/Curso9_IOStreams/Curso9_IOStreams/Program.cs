using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso9_IOStreams
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 048 - FileStream
            // Exercicio 049 - Encoding

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
            //var utf8 = new UTF8Encoding();
            //var texto = utf8.GetString(buffer);
            //Console.Write(texto);

            foreach (var b in buffer)
            {
                Console.Write((char)b);
                //Console.Write(" ");
            }
        }
    }
}
