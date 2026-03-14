using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorBiblioteca.Domain.Interfaces
{
    public interface IEmprestavel
    {
        public void Emprestar();
        public void Devolver();

    }
}
