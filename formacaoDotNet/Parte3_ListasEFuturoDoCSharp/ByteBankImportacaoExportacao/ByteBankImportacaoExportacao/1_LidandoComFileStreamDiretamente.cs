using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "../../../../Curso9_IOStreams/contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    //Console.WriteLine($"\nBytes lidos: {numeroDeBytesLidos}\n");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }

        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.UTF8;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }
    }

}