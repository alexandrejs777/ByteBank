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
            ContaCorrente contaCorrenteDaGabriela = new ContaCorrente();

            contaCorrenteDaGabriela.titular = "Gabriela";
            contaCorrenteDaGabriela.agencia = 863;
            contaCorrenteDaGabriela.numero = 863114;
            contaCorrenteDaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaCorrenteDaGabriela.titular);
            Console.WriteLine("Agência: " + contaCorrenteDaGabriela.agencia);
            Console.WriteLine("Número: " + contaCorrenteDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaCorrenteDaGabriela.saldo);

            contaCorrenteDaGabriela.saldo += 200;
            Console.WriteLine("Saldo atualizado: " + contaCorrenteDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
