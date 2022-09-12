using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPI_EF.Migrations
{
    public partial class nullableValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1455,
                columns: new[] { "FechaDeCreacion", "PrioridadTarea" },
                values: new object[] { new DateTime(2022, 9, 6, 1, 43, 52, 731, DateTimeKind.Local).AddTicks(8201), 2 });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2350,
                columns: new[] { "FechaDeCreacion", "PrioridadTarea" },
                values: new object[] { new DateTime(2022, 9, 6, 1, 43, 52, 731, DateTimeKind.Local).AddTicks(8212), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1455,
                columns: new[] { "FechaDeCreacion", "PrioridadTarea" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 24, 6, 33, DateTimeKind.Local).AddTicks(6301), 0 });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2350,
                columns: new[] { "FechaDeCreacion", "PrioridadTarea" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 24, 6, 33, DateTimeKind.Local).AddTicks(6312), 0 });
        }
    }
}
