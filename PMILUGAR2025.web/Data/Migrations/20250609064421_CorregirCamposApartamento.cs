using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMILUGAR2025.web.Migrations
{
    /// <inheritdoc />
    public partial class CorregirCamposApartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecioMensual",
                table: "Apartamentos",
                newName: "PrecioMesual");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecioMesual",
                table: "Apartamentos",
                newName: "PrecioMensual");
        }
    }
}
