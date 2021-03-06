using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Medicos",
                columns: table => new
                {
                    MedicoModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Especialidade = table.Column<int>(type: "int", nullable: true),
                    Crm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Medicos", x => x.MedicoModelID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Pacientes",
                columns: table => new
                {
                    PacienteModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Pacientes", x => x.PacienteModelID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Remedios",
                columns: table => new
                {
                    RemedioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Remedios", x => x.RemedioID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Consultas",
                columns: table => new
                {
                    ConsultaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicoModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Consultas", x => x.ConsultaID);
                    table.ForeignKey(
                        name: "FK_TB_Consultas_TB_Medicos_MedicoModelID",
                        column: x => x.MedicoModelID,
                        principalTable: "TB_Medicos",
                        principalColumn: "MedicoModelID");
                    table.ForeignKey(
                        name: "FK_TB_Consultas_TB_Pacientes_PacienteModelID",
                        column: x => x.PacienteModelID,
                        principalTable: "TB_Pacientes",
                        principalColumn: "PacienteModelID");
                });

            migrationBuilder.CreateTable(
                name: "TB_Enderecos",
                columns: table => new
                {
                    EnderecoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Enderecos", x => x.EnderecoID);
                    table.ForeignKey(
                        name: "FK_TB_Enderecos_TB_Pacientes_PacienteModelID",
                        column: x => x.PacienteModelID,
                        principalTable: "TB_Pacientes",
                        principalColumn: "PacienteModelID");
                });

            migrationBuilder.CreateTable(
                name: "TB_Reservas",
                columns: table => new
                {
                    ReservaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RemedioID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PacienteID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataReserva = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Reservas", x => x.ReservaID);
                    table.ForeignKey(
                        name: "FK_TB_Reservas_TB_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "TB_Pacientes",
                        principalColumn: "PacienteModelID");
                    table.ForeignKey(
                        name: "FK_TB_Reservas_TB_Remedios_RemedioID",
                        column: x => x.RemedioID,
                        principalTable: "TB_Remedios",
                        principalColumn: "RemedioID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Consultas_MedicoModelID",
                table: "TB_Consultas",
                column: "MedicoModelID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Consultas_PacienteModelID",
                table: "TB_Consultas",
                column: "PacienteModelID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos",
                column: "PacienteModelID",
                unique: true,
                filter: "[PacienteModelID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Reservas_PacienteID",
                table: "TB_Reservas",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Reservas_RemedioID",
                table: "TB_Reservas",
                column: "RemedioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Consultas");

            migrationBuilder.DropTable(
                name: "TB_Enderecos");

            migrationBuilder.DropTable(
                name: "TB_Reservas");

            migrationBuilder.DropTable(
                name: "TB_Medicos");

            migrationBuilder.DropTable(
                name: "TB_Pacientes");

            migrationBuilder.DropTable(
                name: "TB_Remedios");
        }
    }
}
