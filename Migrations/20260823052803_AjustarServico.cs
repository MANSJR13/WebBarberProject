using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBarber.Migrations
{
    /// <inheritdoc />
    public partial class AjustarServico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Servicos");

            migrationBuilder.AddColumn<int>(
                name: "Duracao",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Servicos");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duracao",
                table: "Servicos",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0));
        }
    }
}
