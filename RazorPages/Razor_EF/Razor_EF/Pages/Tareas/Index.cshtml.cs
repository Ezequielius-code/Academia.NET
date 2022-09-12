using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_EF.Context;
using Razor_EF.Models;

namespace Razor_EF.Pages.Tareas
{
    public class IndexModel : PageModel
    {
        //Traigo una instancia del contexto para vincular
        private readonly TareasContext _contexto;

        //Defino el constructor de la clase
        public IndexModel(TareasContext contexto)
        {
            _contexto = contexto;
        }

        //Defino una coleccion enumerable a pasar
        public IEnumerable<Tarea> TareasListadas { get; set; }

        //Método asíncrono para llamar a la conexión
        public async Task OnGet()
        {
            TareasListadas = await _contexto.Tareas.ToListAsync();
        }
    }
}
