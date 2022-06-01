namespace filmes_series._base.baserepository;

public interface IBaseRepository<T> where T : class
{
    public List<T> FindAll();
    public T GetById(int id);
    public bool Adicionar(T _obj);
    public bool Atualizar(int id, T _obj);
    public bool Excluir(int id);
}
