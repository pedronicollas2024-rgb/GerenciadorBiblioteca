# 📚 Sistema de Gerenciamento de Biblioteca

Projeto desenvolvido em **C#** para praticar os conceitos de **Programação Orientada a Objetos (POO)**.

## 🎯 Sobre o Projeto

Sistema de gerenciamento de biblioteca que permite cadastrar livros, usuários e realizar empréstimos e devoluções.

## 🏗️ Estrutura do Projeto

```
Biblioteca.sln
├── GerenciadorBiblioteca.Domain/
│   ├── Entities/
│   │   ├── Livros.cs
│   │   ├── LivroFisico.cs
│   │   ├── LivroDigital.cs
│   │   ├── Usuario.cs
│   │   ├── Emprestimo.cs
│   │   └── Biblioteca.cs
│   ├── Exceptions/
│   │   └── LivroIndisponivelException.cs
│   └── Interfaces/
│       └── IEmprestavel.cs
└── Biblioteca.Console/
    └── Program.cs
```

## 🧠 Conceitos de POO Aplicados

| Conceito | Onde foi aplicado |
|---|---|
| **Classes e Objetos** | `Livros`, `Usuario`, `Emprestimo` |
| **Encapsulamento** | `public get / private set` nas propriedades |
| **Herança** | `LivroFisico` e `LivroDigital` herdam de `Livros` |
| **Interface** | `IEmprestavel` com métodos `Emprestar()` e `Devolver()` |
| **Polimorfismo** | `override` no método `MostrarDetalhes()` |
| **Composição** | `Biblioteca` contém listas de livros e usuários |
| **Exceções** | `LivroIndisponivelException` para erros de negócio |

## ⚙️ Funcionalidades

- ✅ Cadastrar livros físicos e digitais
- ✅ Cadastrar usuários
- ✅ Realizar empréstimos
- ✅ Realizar devoluções
- ✅ Buscar livro por ISBN
- ✅ Controle de disponibilidade
- ✅ Exceções customizadas para regras de negócio

## 🚀 Como Rodar

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado
- Visual Studio 2022 ou VS Code

### Passos
1. Clone o repositório
```bash
git clone https://github.com/pedronicollas2024-rgb/Gerenciador-de-biblioteca
```

2. Abra a solution no Visual Studio
```bash
cd Biblioteca
start Biblioteca.slnx
```

3. Defina `Biblioteca.Console` como projeto de inicialização

4. Rode com **Ctrl + F5**

## 🛠️ Tecnologias

- C# / .NET
- Programação Orientada a Objetos

## 👤 Autor

Feito com 💙 durante estudos de C# com foco em POO.
