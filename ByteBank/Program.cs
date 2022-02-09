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
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.nome = "Alexandre";
            cliente.cpf = "345.768.435-21";
            cliente.profissao = "Desenvolvedor C#";

            conta.Titular = cliente;
            
            conta.Saldo = 200;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
