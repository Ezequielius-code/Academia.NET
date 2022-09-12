using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPI_EF.Migrations
{
    public partial class cambiosData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "Categorías",
                keyColumn: "IdCategoria",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Categorías",
                keyColumn: "IdCategoria",
                keyValue: 112);

            migrationBuilder.InsertData(
                table: "Categorías",
                columns: new[] { "IdCategoria", "Descripcion", "Nombre" },
                values: new object[] { 120, "Lo que tengo que hacer", "Asuntos personales" });

            migrationBuilder.InsertData(
                table: "Categorías",
                columns: new[] { "IdCategoria", "Descripcion", "Nombre" },
                values: new object[] { 240, "Lo que me obligan a hacer", "Asuntos laborales" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "IdTarea", "CategoriaId", "Descripcion", "Estado", "FechaDeCreacion", "NombreTarea", "PrioridadTarea", "Procastinable" },
                values: new object[] { 1455, 120, null, false, new DateTime(2022, 9, 4, 21, 24, 6, 33, DateTimeKind.Local).AddTicks(6301), "Cebar mates", 0, false });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "IdTarea", "CategoriaId", "Descripcion", "Estado", "FechaDeCreacion", "NombreTarea", "PrioridadTarea", "Procastinable" },
                values: new object[] { 2350, 240, null, false, new DateTime(2022, 9, 4, 21, 24, 6, 33, DateTimeKind.Local).AddTicks(6312), "Terminar de preparar la minimal API", 0, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "Categorías",
                keyColumn: "IdCategoria",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Categorías",
                keyColumn: "IdCategoria",
                keyValue: 240);

            migrationBuilder.InsertData(
                table: "Categorías",
                columns: new[] { "IdCategoria", "Descripcion", "Nombre" },
                values: new object[] { 111, "Categoría de primer orden", "Primera Categoría" });

            migrationBuilder.InsertData(
                table: "Categorías",
                columns: new[] { "IdCategoria", "Descripcion", "Nombre" },
                values: new object[] { 112, "Categoría de segundo orden", "Segunda Categoría" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "IdTarea", "CategoriaId", "Descripcion", "Estado", "FechaDeCreacion", "NombreTarea", "PrioridadTarea", "Procastinable" },
                values: new object[] { 1151, 111, null, false, new DateTime(2022, 9, 4, 21, 12, 21, 229, DateTimeKind.Local).AddTicks(2214), "Pago de servicios públicos", 1, false });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "IdTarea", "CategoriaId", "Descripcion", "Estado", "FechaDeCreacion", "NombreTarea", "PrioridadTarea", "Procastinable" },
                values: new object[] { 2252, 112, null, false, new DateTime(2022, 9, 4, 21, 12, 21, 229, DateTimeKind.Local).AddTicks(2225), "Terminar de ver película en Netflix", 2, false });
        }
    }
}
