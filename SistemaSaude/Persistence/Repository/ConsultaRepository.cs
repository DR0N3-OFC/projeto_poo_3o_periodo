using Domain.Models;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Persistence.Repository
{
    public class ConsultaRepository : IRepository<Consulta>
    {
        private readonly EFDataContext _context;
        public ConsultaRepository(EFDataContext context)
        {
            _context = context;
        }

        public Consulta Gravar(Consulta t)
        {
            if (t.ConsultaID == null)
            {
                t.GerarID();
                _context.Consultas?.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            return t;
        }

        public Consulta ObterPorID(Guid? id)
        {
            return _context.Consultas.Where(c => c.ConsultaID == id).FirstOrDefault();
        }

        public IReadOnlyCollection<Consulta> ObterTodos()
        {
            return _context.Consultas.AsNoTracking().Include(p => p.Paciente).Include(m => m.Medico)/*.OrderBy(e => e.Paciente.Nome)*/.ToList().AsReadOnly();
        }

        public void Remover(Consulta t)
        {
            _context.Consultas.Remove(t);
            _context.SaveChanges();
        }
    }
}
