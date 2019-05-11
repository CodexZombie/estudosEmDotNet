using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio045_InterfaceIComparable
{
    public class ComparaPorIdade : IComparer<Pessoa>
    {
        public int Compare(Pessoa x, Pessoa y)
        {
            return x.Idade.CompareTo(y.Idade);
        }
    }
}
