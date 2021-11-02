using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiEscuela.Migrations
{
    public partial class primercambio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesores",
                table: "Profesores");

            migrationBuilder.RenameTable(
                name: "Profesores",
                newName: "Profesor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesor",
                table: "Profesor",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesor",
                table: "Profesor");

            migrationBuilder.RenameTable(
                name: "Profesor",
                newName: "Profesores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesores",
                table: "Profesores",
                column: "Id");
        }
    }
}
