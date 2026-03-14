using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorBiblioteca.Domain.Interfaces;

namespace GerenciadorBiblioteca.Domain.Entities
{
    public class Livros : IEmprestavel
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public bool Disponibilidade { get; set; }

        public Livros(string titulo, string autor, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Disponibilidade = true;
   
        }

      

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Titulo = {Titulo}");
            Console.WriteLine($"Autor = {Autor}");
            Console.WriteLine($"ISBN = {ISBN}");
            Console.WriteLine($"Dispomibilidade = {Disponibilidade}");
        }

        public void Emprestar()
        {
          Disponibilidade = false;
        }

        public void Devolver()
        {
            Disponibilidade=true;
        }
    }
}
