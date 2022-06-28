using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;

namespace Persistence.Repository
{
    public class RemedioRepository : IRepository<Remedio>
    {
        private readonly EFDataContext _context;
        public RemedioRepository(EFDataContext context)
        {
            _context = context;
        }

        public Remedio Gravar(Remedio t)
        {
            if (t.RemedioID == null)
            {
                t.GerarID();
                _context.Remedios?.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            return t;
        }

        public Remedio ObterPorID(Guid? id)
        {
            return _context.Remedios.Where(i => i.RemedioID == id).FirstOrDefault();
        }

        public IReadOnlyCollection<Remedio> ObterTodos()
        {
            return _context.Remedios.OrderBy(p => p.Nome).ToList().AsReadOnly();
        }

        public void Remover(Remedio t)
        {
            var reservas = _context.Reservas.Where(r => r.RemedioID == t.RemedioID).ToList();
            foreach(ReservaModel r in reservas)
            {
                _context.Reservas.Remove(r);
            }
            _context.Remedios.Remove(t);
            _context.SaveChanges();
        }
    }
}
