using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        // Construtor
        public Diretor(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando um novo DIRETOR");
        }

        // Metodos

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
