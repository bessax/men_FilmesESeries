namespace filmes_series._base.baserepository;

public interface IBaseRepository<T> where T : class
{
    public List<T> FindAll();
    public T GetById(int id);
    public T Adicionar(T _obj);
    public T Atualizar(int id, T _obj);
    public T Excluir(int id);
  
}
