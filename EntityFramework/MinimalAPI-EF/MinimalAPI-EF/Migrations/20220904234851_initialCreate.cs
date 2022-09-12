using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPI_EF.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorías",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorías", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    IdTarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTarea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadTarea = table.Column<int>(type: "int", nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Procastinable = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.IdTarea);
                    table.ForeignKey(
                        name: "FK_Tareas_Categorías_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorías",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "IdTarea", "CategoriaId", "Descripcion", "FechaDeCreacion", "NombreTarea", "PrioridadTarea", "Procastinable" },
                values: new object[] { 1151, 111, null, new DateTime(2022, 9, 4, 20, 48, 51, 387, DateTimeKind.Local).AddTicks(1413), "Pago de servicios públicos", 1, false });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "IdTarea", "CategoriaId", "Descripcion", "FechaDeCreacion", "NombreTarea", "PrioridadTarea", "Procastinable" },
                values: new object[] { 2252, 112, null, new DateTime(2022, 9, 4, 20, 48, 51, 387, DateTimeKind.Local).AddTicks(1426), "Terminar de ver película en Netflix", 2, false });

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_CategoriaId",
                table: "Tareas",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Categorías");
        }
    }
}
