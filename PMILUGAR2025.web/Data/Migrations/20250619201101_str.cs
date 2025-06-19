using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMILUGAR2025.web.Migrations
{
    /// <inheritdoc />
    public partial class str : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_UsuarioIdId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_UsuarioIdId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "FechaFin",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "UsuarioIdId",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "Reservas",
                newName: "FechaSolicitud");

            migrationBuilder.AddColumn<string>(
                name: "Contacto",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreApartamento",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreUsuario",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "usuario",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_usuario",
                table: "Reservas",
                column: "usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_usuario",
                table: "Reservas",
                column: "usuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_usuario",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_usuario",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Contacto",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "NombreApartamento",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "NombreUsuario",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "usuario",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "FechaSolicitud",
                table: "Reservas",
                newName: "FechaInicio");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFin",
                table: "Reservas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioIdId",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UsuarioIdId",
                table: "Reservas",
                column: "UsuarioIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_UsuarioIdId",
                table: "Reservas",
                column: "UsuarioIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
