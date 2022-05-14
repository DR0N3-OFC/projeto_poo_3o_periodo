using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CreateDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Endereco_EnderecoID",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Consultas_Pacientes_PacienteModelID",
                table: "TB_Consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "TB_Pacientes");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "TB_Enderecos");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_EnderecoID",
                table: "TB_Pacientes",
                newName: "IX_TB_Pacientes_EnderecoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Pacientes",
                table: "TB_Pacientes",
                column: "PacienteModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Enderecos",
                table: "TB_Enderecos",
                column: "EnderecoID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Consultas_TB_Pacientes_PacienteModelID",
                table: "TB_Consultas",
                column: "PacienteModelID",
                principalTable: "TB_Pacientes",
                principalColumn: "PacienteModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Pacientes_TB_Enderecos_EnderecoID",
                table: "TB_Pacientes",
                column: "EnderecoID",
                principalTable: "TB_Enderecos",
                principalColumn: "EnderecoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Consultas_TB_Pacientes_PacienteModelID",
                table: "TB_Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Pacientes_TB_Enderecos_EnderecoID",
                table: "TB_Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Pacientes",
                table: "TB_Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Enderecos",
                table: "TB_Enderecos");

            migrationBuilder.RenameTable(
                name: "TB_Pacientes",
                newName: "Pacientes");

            migrationBuilder.RenameTable(
                name: "TB_Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Pacientes_EnderecoID",
                table: "Pacientes",
                newName: "IX_Pacientes_EnderecoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "PacienteModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "EnderecoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Endereco_EnderecoID",
                table: "Pacientes",
                column: "EnderecoID",
                principalTable: "Endereco",
                principalColumn: "EnderecoID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Consultas_Pacientes_PacienteModelID",
                table: "TB_Consultas",
                column: "PacienteModelID",
                principalTable: "Pacientes",
                principalColumn: "PacienteModelID");
        }
    }
}
