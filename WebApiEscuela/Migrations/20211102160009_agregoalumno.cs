using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiEscuela.Migrations
{
    public partial class agregoalumno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NroMatricula = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");
        }
    }
}
