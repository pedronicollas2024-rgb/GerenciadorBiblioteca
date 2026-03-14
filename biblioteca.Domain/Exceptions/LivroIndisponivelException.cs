using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorBiblioteca.Domain.Exceptions
{
    public class LivroIndisponivelException : Exception
    {

        public LivroIndisponivelException(string mensagem )
            : base(mensagem)
        {
        }
    }
}
