namespace Domain.Repository
{
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> ObterTodos();
        public T ObterPorID(Guid? id);
        public T Gravar(T t);
        public void Remover(T t);
    }
}
