using System;


 public class Livro
{
    private string titulo;
    private string autor;
    private string genero;
    private int anoLancamento;

    public Livro(string titulo, string autor, string genero, int anoLancamento)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.anoLancamento = anoLancamento;
    }

    public void ExibirInfos()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Ano de lançamento: " + anoLancamento);
    }

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }
    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }
    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }
    public int AnoLancamento
    {
        get { return anoLancamento; }
        set { anoLancamento = value; }
    }

}

