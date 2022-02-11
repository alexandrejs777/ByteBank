using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        // Metodos
        public  double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
