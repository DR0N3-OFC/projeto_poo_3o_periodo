using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;

namespace Persistence.Repository
{
    public class EnderecoRepository : IRepository<Endereco>
    {
        private readonly EFDataContext _context;
        public EnderecoRepository(EFDataContext context)
        {
            _context = context;
        }

        public Endereco Gravar(Endereco t)
        {
            if (t.EnderecoID == null)
            {
                t.GerarID();
                _context.Enderecos?.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            return t;
        }

        public Endereco ObterPorID(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Endereco> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Endereco t)
        {
            throw new NotImplementedException();
        }
    }
}
