using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.cpf = "439.684.798.10";
            gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.agencia = 3067;
            conta.numero = 10030678;
            conta.saldo = 500;

            gabriela.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
