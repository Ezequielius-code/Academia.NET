using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MinimalAPI_EF.Models
{
    [Table("Categorías")]
    public class Categoria
    {
        //Atributos
        //[Key]
        public int IdCategoria { get; set; }
        //[MaxLength(150)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [JsonIgnore]
        public ICollection<Tarea> Tareas { get; set; }
    }
}
