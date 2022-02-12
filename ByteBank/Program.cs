using ByteBank.Funcionarios;
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
            Funcionario carlos = new Funcionario("439.798.365-02", 2000);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos: " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor roberta = new Diretor("798.365.439-03", 5000);
            roberta.Nome = "Roberta";

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);

            Funcionario robertaTeste = roberta;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionária: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
