using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalAPI_EF.Models
{
    [Table("Tareas")]
    public class Tarea
    {
        //[Key]
        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string Descripcion { get; set; }
        public Prioridad PrioridadTarea { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public bool Procastinable { get; set; }
        public bool Estado { get; set; } 
        [NotMapped]
        public string Resumen { get; set; }
        //[ForeignKey("Id Categoría")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}
