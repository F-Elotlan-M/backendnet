namespace backendnet.Models;

public class Pelicula{
    public int PeliculaID{get; set;}
    public string Titulo{get; set;} = "Sin titulo";
    public String Sinopsis{get; set;} = "Sin sipnosis";
    public int Anio{get; set;}
    public string Poster{get; set;} = "N/A";

    public ICollection<Categoria>? Categorias {get; set;}
}