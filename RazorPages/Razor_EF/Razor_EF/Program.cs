using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Razor_EF.Context;
using Razor_EF.Models;

var builder = WebApplication.CreateBuilder(args);

//Conexión a SQLServer
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("conexionTareas"));
//Agregamos Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

//MAPEOS

//GET
app.MapGet("/dbconexion", ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("BBDD en memoria: " + dbContext.Database.IsInMemory());
});
app.MapGet("/listar", ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas.Include(p => p.Categoria));
});

//POST
app.MapPost("/guardar", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) =>
{
    tarea.FechaDeCreacion = DateTime.Now;
    await dbContext.AddAsync(tarea);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

//PUT
app.MapPut("/actualizar/{id}", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea, [FromRoute] int id) =>
{
    var tareaActual = dbContext.Tareas.Find(id);

    if (tareaActual != null)
    {
        tareaActual.NombreTarea = tarea.NombreTarea;
        tareaActual.Descripcion = tarea.Descripcion;
        tareaActual.PrioridadTarea = tarea.PrioridadTarea;
        tareaActual.CategoriaId = tarea.CategoriaId;

        await dbContext.SaveChangesAsync();

        return Results.Ok("Tarea actualizada correctamente.");
    }
    return Results.NotFound("Eso no existe!!!");
});

//DELETE
app.MapDelete("/eliminar/{id}", async ([FromServices] TareasContext dbContext, [FromRoute] int id) =>
{
    var tareaActual = dbContext.Tareas.Find(id);

    if (tareaActual != null)
    {
        dbContext.Remove(tareaActual);
        await dbContext.SaveChangesAsync();
        return Results.Ok("La tarea se ha eliminado correctamente.");
    }
    return Results.NotFound("Eso no existe!!!");
});

app.UseHttpsRedirection();

//Para los estilos
app.UseStaticFiles();

app.UseRouting();

//Para mapear las páginas de Razor
app.MapRazorPages();

app.Run();
