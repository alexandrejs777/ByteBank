using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        // Construtor
        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }


        // Metodos
        public double GetBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }

            return Salario * 0.10;
        }
    }
}
