using Exercicio024_Construtores.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio024_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("123.456.789-10", 2000);
            carlos.Nome = "Carlos";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("234.567.891-11", 5000);
            roberta.Nome = "Roberta";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());


            Console.WriteLine("Salário do Carlos: " + carlos.Salario);
            Console.WriteLine("Salário da Roberta: " + roberta.Salario);

            carlos.AumentarSalario();
            roberta.AumentarSalario();

            Console.WriteLine("NOVO salário do Carlos: " + carlos.Salario);
            Console.WriteLine("NOVO salário da Roberta: " + roberta.Salario);


            Console.ReadLine();
        }
    }
}
