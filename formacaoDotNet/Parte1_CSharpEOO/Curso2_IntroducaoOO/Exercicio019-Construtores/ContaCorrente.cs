namespace Exercicio019_Construtores
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo;

        public ContaCorrente (int agencia, int contaCorrente)
        {
            Agencia = agencia;
            Numero = contaCorrente;

            TotalDeContasCriadas++;
        }


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
                return;
            }
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}

