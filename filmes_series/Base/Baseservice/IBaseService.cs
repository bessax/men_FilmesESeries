namespace filmes_series._base.baseservice
{
    public interface IBaseService<T> where T : class
    {
        public ICollection<T> ObterTodos();
        public T ObterPorId(int id);
        public T Adicionar(T _obj);
        public T Atualizar(int id, T _obj);
        public T Excluir(int id);
    }
}
