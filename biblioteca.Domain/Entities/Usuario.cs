using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorBiblioteca.Domain.Entities
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; } 
        public string CPF { get; private set; }

        public List<Livros> LivrosEmprestados { get; private set; }


        public Usuario(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            LivrosEmprestados = new List<Livros>();
        }
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Nome = {Nome}");
            Console.WriteLine($"Email = {Email}");
            Console.WriteLine($"CPF = {CPF}");
           
        }
    }
}
