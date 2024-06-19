using System.Runtime.InteropServices;

public class Livro {
    public string Titulo;
    public double Preco;
    public Autor Autor;

    public Livro(string Titulo, Autor Autor){
        this.Titulo = Titulo;
        this.Autor = Autor;
    }

    public Livro(string Titulo, Autor Autor, double Preco){
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.Preco = Preco;
    }

    public void AplicarDesconto (double valor){
        Preco -= Preco*(valor/100);
    }

    public void AplicarDesconto (int valor){
        Preco -= Preco - valor;
    }

    public void MostrarInfo(){
        Console.WriteLine($"Livro: {Titulo} | Autor: {Autor} | Preço do livro {Preco}");
    }

}