using ByteBankImportacaoExportacao.Modelos;
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
                    var conta = ConverterStringParaContaCorrente(linha);
                    var msg = $"Ag.: {conta.Agencia} C/C: {conta.Numero} Saldo: R$ {conta.Saldo} Titular: {conta.Titular.Nome}";
                    Console.WriteLine(msg);
                }
            }
            
            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(' ');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2];
            var nomeTitular = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
