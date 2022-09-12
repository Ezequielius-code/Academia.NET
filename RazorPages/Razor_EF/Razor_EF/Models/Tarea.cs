using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_EF.Models
{
    [Table("Tareas")]
    public class Tarea
    {
        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string Descripcion { get; set; }
        public Prioridad PrioridadTarea { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public bool Procastinable { get; set; }
        public Estado Estado { get; set; }
        [NotMapped]
        public string Resumen { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }

    public enum Estado
    {
        Completada,
        EnTransición,
        Pendiente
    }
}