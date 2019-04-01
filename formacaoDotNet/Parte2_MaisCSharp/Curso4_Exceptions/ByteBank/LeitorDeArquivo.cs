﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo o Arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando o arquivo.");
        }
    }
}
