using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMILUGAR2025.web.Migrations
{
    /// <inheritdoc />
    public partial class AddImagenUrlsToApartamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagenUrl",
                table: "Apartamentos",
                newName: "ImagenUrls");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagenUrls",
                table: "Apartamentos",
                newName: "ImagenUrl");
        }
    }
}
