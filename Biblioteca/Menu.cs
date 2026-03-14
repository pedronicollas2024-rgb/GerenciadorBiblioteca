using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorBiblioteca.Domain.Entities;

namespace Biblioteca
{
    public class Menu
    {
        private Acervo _biblioteca;

        public Menu()
        {
            _biblioteca = new Acervo();
        }
        public void Executar()
        {
            bool rodando = true;
            while (rodando)
            {
                string menu = $"Menu Principal:\n" +
                              "1. Cadastrar Livro\n" +
                              "2. Cadastrar Usuário\n" +
                              "3. Realizar Empréstimo\n" +
                              "4. Realizar Devolução\n" +
                              "5. Listar Livros\n" +
                              "0. Sair";
                Console.WriteLine(menu);
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarLivro();
                        break;
                    case "2":
                        CadastrarUsuario();
                        break;
                    case "3":
                        RealizarEmprestimo();
                        break;
                    case "4":
                        RealizarDevolucao();
                        break;
                    case "5":
                        ListarLivros();
                        break;
                    case "0":
                        rodando = false;
                        break;
                }
            }
        }

        private void ListarLivros()
        {
            Console.WriteLine("");
        }

        private void RealizarDevolucao()
        {
            Console.WriteLine("A");
        }

        private void RealizarEmprestimo()
        {
            Console.WriteLine("Digite o ISBN do livro:");


        }

        private void CadastrarUsuario()
        { 
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu email:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite seu CPF:");
            string cpf = Console.ReadLine();

            Usuario usuario = new Usuario(nome, email, cpf);
            _biblioteca.AdicionarUsuario(usuario);
            Console.WriteLine("Usuario cadastrado com sucesso!");

        }



        private void CadastrarLivro()
        {
            Console.WriteLine("1- Livro Físico ou 2 Livro Digital");
            int tipoLivro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite o Autor:");
            string autor = Console.ReadLine();
            Console.WriteLine("Digite o ISBN:");
            string isbn = Console.ReadLine();


            if (tipoLivro == 1)
            {
                Console.WriteLine("Digite Numero de paginas:");
                int numeroPaginas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a localização");
                string localizacao = Console.ReadLine();

                Livros livroFisico = new LivroFisico(titulo, autor, isbn, numeroPaginas, localizacao);
                _biblioteca.AdicionarLivro(livroFisico);
            }
            else
            {
                Console.WriteLine("Digite o formato do aquivo:");
                string formatoArquivo = Console.ReadLine();

                Console.WriteLine("Digite o tamanho em MB:");
                Double tamanhoMB = double.Parse(Console.ReadLine());

                Livros livroDigital = new LivroDigital(titulo, autor, isbn, formatoArquivo, tamanhoMB);
                _biblioteca.AdicionarLivro(livroDigital);

            }
            Console.WriteLine("Livro cadastrado com sucesso!");
        }
    }
}