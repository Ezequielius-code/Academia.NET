using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Context
{
    public class LibrosContext : DbContext
    {
        public LibrosContext(DbContextOptions<LibrosContext> options) : base(options)
        { }

        DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>(libro =>
            {
                libro.ToTable("Libros");
                libro.HasKey(p => p.IdLibro);
                libro.Property(p => p.Titulo);
                libro.Property(p => p.Autor);
                libro.Property(p => p.Genero);
                libro.Property(p => p.Portada);
                libro.Property(p => p.FechaIngreso);
                libro.Property(p => p.FechaPublicacion);
            });
        }
    }
}
