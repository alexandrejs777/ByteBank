
namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;


        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            this.saldo = saldo;
        }


        public double ObterSaldo()
        {
            return saldo;
        }


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


        public bool Transferir(double valor, ContaCorrente contaDeDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDeDestino.Depositar(valor);
            return true;
        }
    }
}

    