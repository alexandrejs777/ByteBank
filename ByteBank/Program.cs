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
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Número: " + conta.Numero);

            Console.ReadLine();
        }
    }
}
