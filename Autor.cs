using System.Runtime.CompilerServices;

public class Autor {
    public string Nome;
    public string Nacionalidade;

    public Autor(string Nome, string Nacionalidade) {
        this.Nome = Nome;
        this.Nacionalidade = Nacionalidade;
    }

    public void MostrarInfo(){
        Console.WriteLine($"Autor: {Nome} | Nacionalidade do autor: {Nacionalidade}");
    }
}


