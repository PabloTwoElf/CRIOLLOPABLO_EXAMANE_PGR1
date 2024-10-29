using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRIOLLOPABLO_EXAMANE_PGR1.Migrations
{
    /// <inheritdoc />
    public partial class CambioBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Año",
                table: "Celular",
                newName: "Anio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Anio",
                table: "Celular",
                newName: "Año");
        }
    }
}
