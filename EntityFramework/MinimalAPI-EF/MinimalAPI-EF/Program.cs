using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalAPI_EF.Context;
using MinimalAPI_EF.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDb"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("conexionTareas"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconexion", ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("BBDD en memoria: " + dbContext.Database.IsInMemory());
});

app.MapGet("/listar", ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas.Include(p => p.Categoria));
});
app.MapPost("/guardar", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) =>
{
    tarea.FechaDeCreacion = DateTime.Now;
    await dbContext.AddAsync(tarea);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});
app.MapPut("/actualizar/{id}", async([FromServices] TareasContext dbContext, [FromBody] Tarea tarea, [FromRoute] int id) =>
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
app.MapDelete("/eliminar/{id}", async([FromServices] TareasContext dbContext, [FromRoute] int id) =>
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

app.Run();
