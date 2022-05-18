using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;

namespace Persistence.Repository
{
    public class MedicoModelRepository : IRepository<MedicoModel>
    {
        private readonly EFDataContext _context;
        public MedicoModelRepository(EFDataContext context)
        {
            _context = context;
        }
        public MedicoModel Gravar(MedicoModel t)
        {
            if (t.MedicoModelID == null)
            {
                t.GerarID();
                _context.Medicos?.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            return t;
        }

        public MedicoModel ObterPorID(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<MedicoModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(MedicoModel t)
        {
            throw new NotImplementedException();
        }
    }
}
