using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        // Construtores
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando GERENTE DE CONTA");
        }

        // Métodos

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
