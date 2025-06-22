using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiProyectogimnasio.Migrations
{
    /// <inheritdoc />
    public partial class ClasesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreClase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clases");
        }
    }
}
