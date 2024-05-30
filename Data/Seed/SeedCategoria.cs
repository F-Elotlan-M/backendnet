using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;
public class SeedCategoria : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasData(
         new Categoria { CategoriaID = 1, Nombre = "Acción", Protegida = true },
            new Categoria { CategoriaID = 2, Nombre = "Aventura", Protegida = true },
            new Categoria { CategoriaID = 3, Nombre = "Animación", Protegida = true },
            new Categoria { CategoriaID = 4, Nombre = "Ciencia ficción", Protegida = true },
            new Categoria { CategoriaID = 5, Nombre = "Comedia", Protegida = true },
            new Categoria { CategoriaID = 6, Nombre = "Crimen", Protegida = true },
            new Categoria { CategoriaID = 7, Nombre = "Documental", Protegida = true },
            new Categoria { CategoriaID = 8, Nombre = "Drama", Protegida = true },
            new Categoria { CategoriaID = 9, Nombre = "Familiar", Protegida = true },
            new Categoria { CategoriaID = 10, Nombre = "Fantasia", Protegida = true },
            new Categoria { CategoriaID = 11, Nombre = "Historia", Protegida = true },
            new Categoria { CategoriaID = 12, Nombre = "Horror", Protegida = true },
            new Categoria { CategoriaID = 13, Nombre = "Musica", Protegida = true },
            new Categoria { CategoriaID = 14, Nombre = "Misterio", Protegida = true },
            new Categoria { CategoriaID = 15, Nombre = "Romance", Protegida = true }
        );
    }
}