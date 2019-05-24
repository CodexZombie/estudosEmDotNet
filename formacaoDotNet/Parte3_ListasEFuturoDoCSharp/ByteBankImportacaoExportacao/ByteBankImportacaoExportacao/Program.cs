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
        static void Main(string[] args)
        {
            var arquivoURL = "../../../../Curso9_IOStreams/contas.txt";

            using(var fluxoDoArquivo = new FileStream(arquivoURL, FileMode.Open))
            using(var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }

            Console.ReadLine();
        }
    }
}
