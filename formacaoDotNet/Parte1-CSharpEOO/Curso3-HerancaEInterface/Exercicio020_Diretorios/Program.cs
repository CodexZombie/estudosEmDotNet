using Exercicio020_Diretorios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio020_Diretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-10";
            carlos.Salario = 2000.58;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());


            Console.ReadLine();
        }
    }
}
