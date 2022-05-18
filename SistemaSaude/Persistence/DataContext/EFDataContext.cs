using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<PacienteModel>? Pacientes { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }
        public DbSet<MedicoModel>? Medicos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PacienteModel>().ToTable("TB_Pacientes");
            modelBuilder.Entity<MedicoModel>().ToTable("TB_Medicos");
            modelBuilder.Entity<Endereco>().ToTable("TB_Enderecos");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBSaude;Trusted_Connection=True");
        }
    }
}
