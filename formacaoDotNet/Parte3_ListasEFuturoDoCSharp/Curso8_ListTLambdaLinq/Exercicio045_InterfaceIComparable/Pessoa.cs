using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio045_InterfaceIComparable
{
    public class Pessoa : IComparable
    {
        public string Nome { get; }
        public int Idade { get; }

        public Pessoa (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Retornar negativo quando a instância precede o obj;
        // Retornar zero quando a instância e obj forem equivalentes;
        // Retornar positivo diferente de zero quando a precedência for de obj;
        public int CompareTo(object obj)
        {
            var p2 = obj as Pessoa;
            return String.Compare(Nome, p2.Nome);
        }
    }
}
