namespace Exercicio017_Namespaces
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}

