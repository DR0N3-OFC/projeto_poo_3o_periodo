using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Pacientes_TB_Enderecos_EnderecoID",
                table: "TB_Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_TB_Pacientes_EnderecoID",
                table: "TB_Pacientes");

            migrationBuilder.DropColumn(
                name: "EnderecoID",
                table: "TB_Pacientes");

            migrationBuilder.AddColumn<Guid>(
                name: "PacienteModelID",
                table: "TB_Enderecos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos",
                column: "PacienteModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Enderecos_TB_Pacientes_PacienteModelID",
                table: "TB_Enderecos",
                column: "PacienteModelID",
                principalTable: "TB_Pacientes",
                principalColumn: "PacienteModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Enderecos_TB_Pacientes_PacienteModelID",
                table: "TB_Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_TB_Enderecos_PacienteModelID",
                table: "TB_Enderecos");

            migrationBuilder.DropColumn(
                name: "PacienteModelID",
                table: "TB_Enderecos");

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoID",
                table: "TB_Pacientes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_Pacientes_EnderecoID",
                table: "TB_Pacientes",
                column: "EnderecoID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Pacientes_TB_Enderecos_EnderecoID",
                table: "TB_Pacientes",
                column: "EnderecoID",
                principalTable: "TB_Enderecos",
                principalColumn: "EnderecoID");
        }
    }
}
