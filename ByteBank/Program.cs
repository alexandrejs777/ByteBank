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
            ContaCorrente conta1 = new ContaCorrente(867, 86712540);

            Console.WriteLine("Agência: " + conta1.Agencia);
            Console.WriteLine("Número: " + conta1.Numero);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(867, 86715435);
            Console.WriteLine("Agência: " + conta2.Agencia);
            Console.WriteLine("Número: " + conta2.Numero);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
