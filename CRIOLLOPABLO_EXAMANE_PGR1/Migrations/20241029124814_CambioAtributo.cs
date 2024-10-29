using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRIOLLOPABLO_EXAMANE_PGR1.Migrations
{
    /// <inheritdoc />
    public partial class CambioAtributo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCriollo_Celular_celularId",
                table: "PCriollo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Celular",
                table: "Celular");

            migrationBuilder.RenameColumn(
                name: "celularId",
                table: "PCriollo",
                newName: "celularAño");

            migrationBuilder.RenameIndex(
                name: "IX_PCriollo_celularId",
                table: "PCriollo",
                newName: "IX_PCriollo_celularAño");

            migrationBuilder.RenameColumn(
                name: "Anio",
                table: "Celular",
                newName: "Año");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Celular",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Año",
                table: "Celular",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Celular",
                table: "Celular",
                column: "Año");

            migrationBuilder.AddForeignKey(
                name: "FK_PCriollo_Celular_celularAño",
                table: "PCriollo",
                column: "celularAño",
                principalTable: "Celular",
                principalColumn: "Año",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCriollo_Celular_celularAño",
                table: "PCriollo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Celular",
                table: "Celular");

            migrationBuilder.RenameColumn(
                name: "celularAño",
                table: "PCriollo",
                newName: "celularId");

            migrationBuilder.RenameIndex(
                name: "IX_PCriollo_celularAño",
                table: "PCriollo",
                newName: "IX_PCriollo_celularId");

            migrationBuilder.RenameColumn(
                name: "Año",
                table: "Celular",
                newName: "Anio");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Celular",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Anio",
                table: "Celular",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Celular",
                table: "Celular",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCriollo_Celular_celularId",
                table: "PCriollo",
                column: "celularId",
                principalTable: "Celular",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
