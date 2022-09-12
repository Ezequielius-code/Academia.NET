using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPI_EF.Migrations
{
    public partial class EstadoTarea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Tareas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1151,
                column: "FechaDeCreacion",
                value: new DateTime(2022, 9, 4, 21, 8, 0, 354, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2252,
                column: "FechaDeCreacion",
                value: new DateTime(2022, 9, 4, 21, 8, 0, 354, DateTimeKind.Local).AddTicks(2846));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Tareas");

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1151,
                column: "FechaDeCreacion",
                value: new DateTime(2022, 9, 4, 20, 48, 51, 387, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2252,
                column: "FechaDeCreacion",
                value: new DateTime(2022, 9, 4, 20, 48, 51, 387, DateTimeKind.Local).AddTicks(1426));
        }
    }
}
