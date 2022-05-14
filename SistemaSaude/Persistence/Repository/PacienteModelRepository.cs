using Domain.Models;
using Domain.Repository;
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
            throw new NotImplementedException();
        }

        public PacienteModel ObterPorID(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<PacienteModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(PacienteModel t)
        {
            throw new NotImplementedException();
        }
    }
}
