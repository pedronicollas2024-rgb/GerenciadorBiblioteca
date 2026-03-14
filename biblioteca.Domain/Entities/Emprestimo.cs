using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorBiblioteca.Domain.Exceptions;

namespace GerenciadorBiblioteca.Domain.Entities
{
    public class Emprestimo 
    {
        public Livros Livro { get; private set; }
        public Usuario Usuario { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Emprestimo(Livros livro, Usuario usuario)
        {
            Livro = livro;
            Usuario = usuario;
            DataEmprestimo = DateTime.Now;

        }

        public void RealizarEmprestimo()
        {
            if (Livro.Disponibilidade)
            {
                Livro.Emprestar();
                Console.WriteLine("Livro emprestado com sucesso!");
            }
            else
            {
                throw new LivroIndisponivelException ("Livro indisponível para empréstimo.");
            }
        }
        public void RealizarDevolucao()
        {
            Livro.Devolver();
            DataDevolucao = DateTime.Now;
            Console.WriteLine("Livro devolvido com sucesso!");
        }
    }
}
