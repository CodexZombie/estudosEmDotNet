using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio049_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 049 - ENCODING

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
            var encoding = new UTF8Encoding();
            var texto = encoding.GetString(buffer);
            Console.Write(texto);
        }
    }
}
