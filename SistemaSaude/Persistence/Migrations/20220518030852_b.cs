using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos");

            migrationBuilder.CreateTable(
                name: "TB_Medicos",
                columns: table => new
                {
                    MedicoModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Medicos", x => x.MedicoModelID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos",
                column: "PacienteModelID",
                unique: true,
                filter: "[PacienteModelID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Medicos");

            migrationBuilder.DropIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos",
                column: "PacienteModelID");
        }
    }
}
