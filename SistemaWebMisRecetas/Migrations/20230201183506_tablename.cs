using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class tablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recetas",
                table: "Recetas");

            migrationBuilder.RenameTable(
                name: "Recetas",
                newName: "Receta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receta",
                table: "Receta",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Receta",
                table: "Receta");

            migrationBuilder.RenameTable(
                name: "Receta",
                newName: "Recetas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recetas",
                table: "Recetas",
                column: "Id");
        }
    }
}
