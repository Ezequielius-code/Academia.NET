namespace Biblioteca.Models
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Genero { get; set; }
        public string? Portada { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
