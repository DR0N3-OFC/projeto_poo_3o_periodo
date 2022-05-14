using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<PacienteModel>? Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBSaude;Trusted_Connection=True");
        }
    }
}
