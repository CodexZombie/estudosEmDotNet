using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução finalizada.");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}

            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }

        private void TestaInnerException()
        {
            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(123, 1234567);
            //    conta.Depositar(100);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(150);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(10);
            //    Console.WriteLine(conta.Saldo);

            //    ContaCorrente conta2 = new ContaCorrente(123, 2345678);

            //    Console.WriteLine("Saldo da conta 2: " + conta2.Saldo);
            //    Console.WriteLine("Saldo da conta 1: " + conta.Saldo);

            //    conta2.Transferir(50, conta);

            //    Console.WriteLine("Saldo da conta 2: " + conta2.Saldo);
            //    Console.WriteLine("Saldo da conta 1: " + conta.Saldo);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.GetType());
            //    Console.WriteLine(e.Message);
            //}
            //catch (SaldoInsuficienteException e)
            //{
            //    Console.WriteLine("Saldo na conta: " + e.Saldo);
            //    Console.WriteLine("Tentativa de Saque: " + e.ValorSaque);
            //    Console.WriteLine(e.GetType());
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.GetType());
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                ContaCorrente conta1 = new ContaCorrente(123, 123456);
                ContaCorrente conta2 = new ContaCorrente(123, 234567);

                conta1.Transferir(10000, conta2);
            }
            //catch (Exception e)
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("exceção interna");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }

        }
    }
}
