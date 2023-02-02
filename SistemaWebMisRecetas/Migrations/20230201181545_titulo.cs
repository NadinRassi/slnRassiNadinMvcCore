using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class titulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Recetas",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Recetas");
        }
    }
}
