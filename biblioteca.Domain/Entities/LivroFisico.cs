using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorBiblioteca.Domain.Entities
{
    public class LivroFisico : Livros
    {
        public int NumeroPaginas { get; private set; }
        public string Localizacao { get; private set; }

        public LivroFisico(string titulo, string autor, string isbn, int numeroPaginas, string localizacao)
            : base(titulo, autor, isbn)
        {
            NumeroPaginas = numeroPaginas;
            Localizacao = localizacao;
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine($"Numero da página {NumeroPaginas}");
            Console.WriteLine($"Localização {Localizacao}");
           
        }
    }
}
