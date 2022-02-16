
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int Numero { get; }

        public static int TotalDeContasCriadas { get; private set; }

        public static double TaxaOperacao { get; private set; }


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
            if (agencia <= 0)
            {
                throw new ArgumentException("O número da agência não pode ser igual ou menor que zero!", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número da conta não pode ser igual ou menor que zero!", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            //try
            //{
                TaxaOperacao = 30 / TotalDeContasCriadas;
            //}
            //catch (DivideByZeroException)
            //{
                //Console.WriteLine("Não foi possível dividir a taxa de operação. Pois o total de contas criadas é igual a zero.");
            //}

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

    