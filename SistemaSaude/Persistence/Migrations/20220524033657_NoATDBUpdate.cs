using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class NoATDBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "TB_Pacientes");

            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "TB_Medicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountType",
                table: "TB_Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountType",
                table: "TB_Medicos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
