using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio051_TrabalhandoComBuffers
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 051 - TRABALHANDO COM BUFFERS

            var arquivoURL = "../../../contas.txt";

            using (var fluxoDoArquivo = new FileStream(arquivoURL, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1 kb
                var bytesLidos = -1;

                while (bytesLidos != 0)
                {
                    bytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                    if(bytesLidos != 0)
                    {
                        EscreverBuffer(buffer, bytesLidos);
                    }
                }
            }

            Console.ReadLine();
        }


        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var encoding = new UTF8Encoding();
            var texto = encoding.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }
    }
}
