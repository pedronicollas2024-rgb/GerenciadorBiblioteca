using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorBiblioteca.Domain.Entities
{
    public class LivroDigital : Livros
    {
        public string FormatoArquivo { get; private set; }
        public double TamanhoMB { get; private set; }

        public LivroDigital(string titulo, string autor, string isbn, string formatoArquivo, double tamanhoMB)
            : base(titulo, autor, isbn)
        {
            FormatoArquivo = formatoArquivo;
            TamanhoMB = tamanhoMB;
        }
        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine($"Formato do arquivo {FormatoArquivo}");
            Console.WriteLine($"Tamanho em MB {TamanhoMB}");
        }
    }
}
