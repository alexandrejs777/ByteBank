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
            Cliente cliente1 = new Cliente();

            cliente1.Nome = "Alexandre";
            conta1.Titular = cliente1;

            Console.WriteLine("Cliente: " + conta1.Titular.Nome);
            Console.WriteLine("Agência: " + conta1.Agencia);
            Console.WriteLine("Número: " + conta1.Numero);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);


            ContaCorrente conta2 = new ContaCorrente(867, 86715435);
            Cliente cliente2 = new Cliente();

            cliente2.Nome = "Bruna";
            conta2.Titular = cliente2;

            Console.WriteLine("Cliente: " + conta2.Titular.Nome);
            Console.WriteLine("Agência: " + conta2.Agencia);
            Console.WriteLine("Número: " + conta2.Numero);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
