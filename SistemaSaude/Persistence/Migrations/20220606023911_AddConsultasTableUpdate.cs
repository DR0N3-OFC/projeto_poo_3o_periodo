using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddConsultasTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Medico",
                table: "TB_Consultas",
                newName: "NomeMedico");

            migrationBuilder.AddColumn<Guid>(
                name: "MedicoModelID",
                table: "TB_Consultas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_Consultas_MedicoModelID",
                table: "TB_Consultas",
                column: "MedicoModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Consultas_TB_Medicos_MedicoModelID",
                table: "TB_Consultas",
                column: "MedicoModelID",
                principalTable: "TB_Medicos",
                principalColumn: "MedicoModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Consultas_TB_Medicos_MedicoModelID",
                table: "TB_Consultas");

            migrationBuilder.DropIndex(
                name: "IX_TB_Consultas_MedicoModelID",
                table: "TB_Consultas");

            migrationBuilder.DropColumn(
                name: "MedicoModelID",
                table: "TB_Consultas");

            migrationBuilder.RenameColumn(
                name: "NomeMedico",
                table: "TB_Consultas",
                newName: "Medico");
        }
    }
}
