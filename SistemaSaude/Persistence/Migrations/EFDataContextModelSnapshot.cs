﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.DataContext;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(EFDataContext))]
    partial class EFDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Consulta", b =>
                {
                    b.Property<Guid?>("ConsultaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MedicoModelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PacienteModelID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ConsultaID");

                    b.HasIndex("MedicoModelID");

                    b.HasIndex("PacienteModelID");

                    b.ToTable("TB_Consultas", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Endereco", b =>
                {
                    b.Property<Guid?>("EnderecoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PacienteModelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoID");

                    b.HasIndex("PacienteModelID")
                        .IsUnique()
                        .HasFilter("[PacienteModelID] IS NOT NULL");

                    b.ToTable("TB_Enderecos", (string)null);
                });

            modelBuilder.Entity("Domain.Models.MedicoModel", b =>
                {
                    b.Property<Guid?>("MedicoModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Crm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Especialidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicoModelID");

                    b.ToTable("TB_Medicos", (string)null);
                });

            modelBuilder.Entity("Domain.Models.PacienteModel", b =>
                {
                    b.Property<Guid?>("PacienteModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacienteModelID");

                    b.ToTable("TB_Pacientes", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Consulta", b =>
                {
                    b.HasOne("Domain.Models.MedicoModel", "Medico")
                        .WithMany("Consultas")
                        .HasForeignKey("MedicoModelID");

                    b.HasOne("Domain.Models.PacienteModel", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteModelID");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Domain.Models.Endereco", b =>
                {
                    b.HasOne("Domain.Models.PacienteModel", "Paciente")
                        .WithOne("Endereco")
                        .HasForeignKey("Domain.Models.Endereco", "PacienteModelID");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Domain.Models.MedicoModel", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Domain.Models.PacienteModel", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
