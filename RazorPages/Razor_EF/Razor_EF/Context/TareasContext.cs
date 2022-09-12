using Microsoft.EntityFrameworkCore;
using Razor_EF.Models;

namespace Razor_EF.Context
{
    public class TareasContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Categoria> categoriasInit = new List<Categoria>();

            categoriasInit.Add(new Categoria()
            {
                IdCategoria = 120,
                Nombre = "Asuntos personales",
                Descripcion = "Lo que tengo que hacer"
            });
            categoriasInit.Add(new Categoria()
            {
                IdCategoria = 240,
                Nombre = "Asuntos laborales",
                Descripcion = "Lo que me obligan a hacer"
            });

            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categorías");
                categoria.HasKey(p => p.IdCategoria);
                categoria.Property(p => p.Nombre).IsRequired(false).HasMaxLength(150);
                categoria.Property(p => p.Descripcion).IsRequired().HasMaxLength(1000);
                categoria.HasData(categoriasInit);
            });

            List<Tarea> tareasInit = new List<Tarea>();

            tareasInit.Add(new Tarea()
            {
                IdTarea = 1455,
                PrioridadTarea = Prioridad.Alta,
                NombreTarea = "Cebar mates",
                FechaDeCreacion = DateTime.Now,
                CategoriaId = 120
            });
            tareasInit.Add(new Tarea()
            {
                IdTarea = 2350,
                PrioridadTarea = Prioridad.Alta,
                NombreTarea = "Terminar de preparar la minimal API",
                FechaDeCreacion = DateTime.Now,
                CategoriaId = 240
            });

            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tareas");
                tarea.HasKey(p => p.IdTarea);
                tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);
                tarea.Property(p => p.NombreTarea).HasMaxLength(100);
                tarea.Property(p => p.Descripcion);
                tarea.Property(p => p.PrioridadTarea);
                tarea.Property(p => p.FechaDeCreacion);
                tarea.Property(p => p.Procastinable);
                tarea.Property(p => p.Estado);
                tarea.HasData(tareasInit);
                tarea.Ignore(p => p.Resumen);
            });
        }
    }
}
