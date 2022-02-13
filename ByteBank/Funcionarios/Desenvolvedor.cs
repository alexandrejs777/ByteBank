using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        // Construtores
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando DESENVOLVEDOR");
        }

        // Metodos

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
