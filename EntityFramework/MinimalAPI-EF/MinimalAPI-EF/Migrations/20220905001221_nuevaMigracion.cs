using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPI_EF.Migrations
{
    public partial class nuevaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 1151,
                column: "FechaDeCreacion",
                value: new DateTime(2022, 9, 4, 21, 12, 21, 229, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "IdTarea",
                keyValue: 2252,
                column: "FechaDeCreacion",
                value: new DateTime(2022, 9, 4, 21, 12, 21, 229, DateTimeKind.Local).AddTicks(2225));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
