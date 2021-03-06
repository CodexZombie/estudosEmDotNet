﻿using Exercicio028_Interfaces.Funcionarios;
using Exercicio028_Interfaces.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio028_Interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {

            // CalcularBonificacao();

            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123456";

            GerenteDeConta camila = new GerenteDeConta("123.456.789-10");
            camila.Nome = "Camila";
            camila.Senha = "abcdef";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "456789";

            sistemaInterno.Logar(roberta, "123456");
            sistemaInterno.Logar(camila, "abcdef");
            sistemaInterno.Logar(parceiro, "456789");
        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
