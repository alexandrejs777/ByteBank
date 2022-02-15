
namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public static double TaxaOperacao { get; set; }


        private double _saldo = 100;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }


        // Construtores

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        // Métodos e Funções

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }


        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDeDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDeDestino.Depositar(valor);
            return true;
        }
    }
}

    