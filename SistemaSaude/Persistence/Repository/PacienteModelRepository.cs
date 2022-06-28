using Domain.Models;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Persistence.Repository
{
    public class PacienteModelRepository : IRepository<PacienteModel>
    {
        private readonly EFDataContext _context;
        public PacienteModelRepository(EFDataContext context)
        {
            _context = context;
        }
        public PacienteModel Gravar(PacienteModel t)
        {
            if (t.PacienteModelID == null)
            {
                t.GerarID();
                _context.Pacientes?.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            return t;
        }

        public PacienteModel ObterPorID(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<PacienteModel> ObterTodos()
        {
            return _context.Pacientes.AsNoTracking().Include(e => e.Endereco).OrderBy(p => p.Nome).ToList().AsReadOnly();
        }

        public void Remover(PacienteModel t)
        {
            throw new NotImplementedException();
        }
    }
}
