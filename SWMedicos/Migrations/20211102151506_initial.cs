using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWMedicos.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Especialidad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NroMatricula = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Ciudad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
