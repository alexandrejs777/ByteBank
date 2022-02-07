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
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo inicial da conta do Bruno: " + contaDoBruno.saldo);

            bool resultadoDoSaque = contaDoBruno.Sacar(200);

            Console.WriteLine("Saldo da conta do Bruno após o saque: " + contaDoBruno.saldo);
            Console.WriteLine(resultadoDoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo da conta do Bruno após o depósito: " + contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoDaTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno após transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela após transferência: " + contaDaGabriela.saldo);
            Console.WriteLine(resultadoDaTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("Saldo da Gabriela após transferência: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno após transferência: " + contaDoBruno.saldo);
            


            Console.ReadLine();
        }
    }
}
