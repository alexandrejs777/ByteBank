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
            Funcionario carlos = new Funcionario();

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            carlos.Nome = "Carlos";
            carlos.CPF = "439.798.365-02";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "798.365.439-03";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

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
