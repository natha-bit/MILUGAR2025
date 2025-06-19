using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMILUGAR2025.web.Migrations
{
    /// <inheritdoc />
    public partial class stt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_usuario",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_usuario",
                table: "Reservas",
                column: "usuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_usuario",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_usuario",
                table: "Reservas",
                column: "usuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
