using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fsbr_desafio.Migrations
{
    /// <inheritdoc />
    public partial class Genesis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NPU = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDeVisualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Municipio = table.Column<string>(type: "TEXT", nullable: false),
                    Uf = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processos");
        }
    }
}
