using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Razor_EF.Models
{
    [Table("Categorías")]
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [JsonIgnore]
        public ICollection<Tarea> Tareas { get; set; }
    }
}