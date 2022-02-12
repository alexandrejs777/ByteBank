using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public static int TotalDeFuncionarios { get; private set; }

        // Construtor
        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando um novo FUNCIONARIO");
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        // Metodos
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
