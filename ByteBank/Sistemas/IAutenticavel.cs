using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        string Nome { get; set; }
        bool Autenticar(string senha);
    }
}
