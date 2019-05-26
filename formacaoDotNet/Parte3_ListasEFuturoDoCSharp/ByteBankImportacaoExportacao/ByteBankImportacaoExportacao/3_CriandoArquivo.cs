using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "123,4567897,5780.89,Gustavo Franco";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            //using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,65465,456.0,Pedro da Silva");
            }
        }

        static void TestaEscrita()
        {
            var caminhoDoArquivo = "teste.txt";

            using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    Console.WriteLine($"Linha {i} foi escrita no arquivo." +
                        $" Tecle Enter para adicionar mais uma.");
                    escritor.Flush();
                    Console.ReadLine();
                }
            }
        }
    }
}