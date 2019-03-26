using Exercicio028_Interfaces.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio028_Interfaces.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
