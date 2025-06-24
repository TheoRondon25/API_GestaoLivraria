namespace API_GestaoLivraria.Models; 


public class Livraria
{    
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEstoque { get; set; }
}
