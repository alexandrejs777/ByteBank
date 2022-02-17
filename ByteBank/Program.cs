using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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

            try
            {
                ContaCorrente conta1 = new ContaCorrente(167, 167485);
                ContaCorrente conta2 = new ContaCorrente(167, 167486);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);

            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");

                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }

                        
            Console.WriteLine("Operação finalizada! Aperte Enter para encerrar o programa.");

            //CalcularBonificacao();
            //UsarSistema();

            Console.ReadLine();
        }

        /* public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Nome = "Parceiro";
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, roberta.Senha);
            //sistemaInterno.Logar(roberta, "abc");

            sistemaInterno.Logar(camila, camila.Senha);
            //sistemaInterno.Logar(camila, "123");

            sistemaInterno.Logar(parceiro, parceiro.Senha);

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario guilherme = new Desenvolvedor("465.398.739-16");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificação do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }*/
    }
}
