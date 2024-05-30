namespace backendnet.Models;

public class CategoriaDTO{
    public int? CategoriaID {get; set;}
    public required string Nombre {get; set;}
    public bool Protegida {get; set;} = false;
}