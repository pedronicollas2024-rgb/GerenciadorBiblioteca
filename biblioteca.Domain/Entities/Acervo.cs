using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorBiblioteca.Domain.Entities
{
    public class Acervo
    {
        public List<Livros> ListaDeLivros { get; private set; }
        public List<Usuario> Usuarios { get; private set; }

        public Acervo()
        {
            ListaDeLivros = new List<Livros>();
            Usuarios = new List<Usuario>();
        }

        public void AdicionarLivro(Livros livro)
        {
            ListaDeLivros.Add(livro);
        }
        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public Livros BuscarLivroPorISBN(string isbn)
        {
            foreach (Livros catalogo in ListaDeLivros)
            {
                if (catalogo.ISBN == isbn)
                    return catalogo;
            }
            return null;
        }



    }
}
