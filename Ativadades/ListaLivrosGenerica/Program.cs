using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Cria uma lista de livros
        List<Livro> livros = new List<Livro>();

        // Adiciona livros à lista
        livros.Add(new Livro { Nome = "O Senhor dos Anéis", Editora = "Martins Fontes", Autor = "J.R.R. Tolkien", NumeroPaginas = 1170 });
        livros.Add(new Livro { Nome = "O Pequeno Príncipe", Editora = "Editora Sextante", Autor = "Antoine de Saint-Exupéry", NumeroPaginas = 96 });
        // Adicione mais 3 livros aqui

        // Encontra o livro com mais páginas
        Livro livroComMaisPaginas = livros[0];
        foreach (Livro livro in livros)
        {
            if (livro.NumeroPaginas > livroComMaisPaginas.NumeroPaginas)
            {
                livroComMaisPaginas = livro;
            }
        }

        // Imprime as informações do livro com mais páginas
        Console.WriteLine("Livro com mais páginas:");
        Console.WriteLine($"Nome: {livroComMaisPaginas.Nome}");
        Console.WriteLine($"Editora: {livroComMaisPaginas.Editora}");
        Console.WriteLine($"Autor: {livroComMaisPaginas.Autor}");
        Console.WriteLine($"Número de páginas: {livroComMaisPaginas.NumeroPaginas}");
    }
}