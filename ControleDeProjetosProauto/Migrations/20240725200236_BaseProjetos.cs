using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeProjetosProauto.Migrations
{
    /// <inheritdoc />
    public partial class BaseProjetos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projetos",
                columns: table => new
                {
                    PRONID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PROSNPRO = table.Column<string>(type: "TEXT", nullable: false),
                    PRODDATCAD = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PROSDESPRO = table.Column<string>(type: "TEXT", nullable: false),
                    PROCSTAT = table.Column<char>(type: "TEXT", nullable: false),
                    PROSOBRIG = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projetos", x => x.PRONID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projetos");
        }
    }
}
