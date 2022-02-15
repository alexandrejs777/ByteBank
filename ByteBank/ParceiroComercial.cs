using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {

        public string Senha { get; set; }
        public string Nome { get; set; }

        public ParceiroComercial()
        {
            Console.WriteLine("Criando PARCEIRO COMERCIAL");
        }

        public bool Autenticar(string senha)
        {
            return Senha == Senha;
        }
    }
}
