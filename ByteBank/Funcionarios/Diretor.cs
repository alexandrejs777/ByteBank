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
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando um novo DIRETOR");
        }

        // Metodos
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
