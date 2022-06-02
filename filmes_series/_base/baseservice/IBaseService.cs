namespace filmes_series._base.baseservice
{
    public interface IBaseService<T> where T : class
    {
        public List<T> ObterTodos();
        public T ObterPorId(int id);
        public bool Adicionar(T _obj);
        public bool Atualizar(int id, T _obj);
        public bool Excluir(int id);
    }
}
