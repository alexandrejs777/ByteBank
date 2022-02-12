using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        // Construtor
        public Designer(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando DESIGNER");
        }

        // Metodos
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
