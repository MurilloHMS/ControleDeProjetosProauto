using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeProjetosProauto.Migrations
{
    /// <inheritdoc />
    public partial class IncluidoDataEntregaProjetos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PRODDATENT",
                table: "projetos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRODDATENT",
                table: "projetos");
        }
    }
}
