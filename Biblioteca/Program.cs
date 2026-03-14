using Biblioteca;
using GerenciadorBiblioteca.Domain.Entities;
using GerenciadorBiblioteca.Domain.Exceptions;

Livros l = new Livros("O Senhor dos Anéis", "J.R.R. Tolkien", "123456789");
Livros l2 = new Livros("Harry Potter e a Pedra Filosofal", "J.K. Rowling", "987654321");

l.MostrarDetalhes();
l2.MostrarDetalhes();


LivroFisico lf = new LivroFisico("O Hobbit", "J.R.R. Tolkien", "111222333", 310, "Prateleira A3");
lf.MostrarDetalhes();
lf.Emprestar();
Console.WriteLine($"Após emprestar: {lf.Disponibilidade}"); // False

lf.Devolver();
Console.WriteLine($"Após devolver: {lf.Disponibilidade}"); // True


LivroDigital ld = new LivroDigital("O Código Da Vinci", "Dan Brown", "444555666", "PDF", 5.2);
ld.MostrarDetalhes();

// Cria biblioteca, livro e usuario
Acervo biblioteca = new Acervo();
LivroFisico livro = new LivroFisico("O Hobbit", "Tolkien", "111", 310, "Prateleira A3");
Usuario usuario = new Usuario("João", "joao@email.com", "123.456.789-00");

// Adiciona na biblioteca
biblioteca.AdicionarLivro(livro);
biblioteca.AdicionarUsuario(usuario);

// Realiza empréstimo
Emprestimo emprestimo = new Emprestimo(livro, usuario);
emprestimo.RealizarEmprestimo();

try
{
    emprestimo.RealizarEmprestimo();
}
catch (LivroIndisponivelException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

// Devolve
emprestimo.RealizarDevolucao();

Menu menu = new Menu();
menu.Executar();


