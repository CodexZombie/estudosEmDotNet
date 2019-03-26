using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio018_Encapsulamento
{
    public class Cliente
    {
        private string _CPF;

        public string Nome { get; set; }

        public string CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                //lógica de validação do CPF
                _CPF = value;
            }
        }  

        public string Profissao { get; set; }

    }
}
