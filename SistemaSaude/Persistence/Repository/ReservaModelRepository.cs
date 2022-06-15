using Domain.Models;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Persistence.Repository
{
    public class ReservaModelRepository : IRepository<ReservaModel>
    {
        private readonly EFDataContext _context;
        public ReservaModelRepository(EFDataContext context)
        {
            _context = context;
        }
        public ReservaModel Gravar(ReservaModel t)
        {
            if (t.ReservaID == null)
            {
                t.GerarID();
                _context.Reservas?.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            return t;
        }

        public ReservaModel ObterPorID(Guid? id)
        {
            return _context.Reservas.Where(i => i.ReservaID == id).FirstOrDefault();
        }

        public IReadOnlyCollection<ReservaModel> ObterTodos()
        {
            return _context.Reservas.AsNoTracking().Include(p => p.Paciente).Include(r  => r.Remedio).OrderBy(p => p.DataReserva).ToList().AsReadOnly();
        }

        public void Remover(ReservaModel t)
        {
            _context.Reservas.Remove(t);
            _context.SaveChanges();
        }
    }
}
