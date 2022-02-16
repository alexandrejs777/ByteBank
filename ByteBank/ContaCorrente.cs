
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

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }


        // Métodos e Funções

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }

            if (this._saldo < valor)
            {
                //throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de " + valor);
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this._saldo -= valor;

        }


        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDeDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            Sacar(valor);
            contaDeDestino.Depositar(valor);

        }
    }
}

    