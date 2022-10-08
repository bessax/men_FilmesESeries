namespace filmes_series.filmes_series.Base.Baserepository;

public interface IBaseRepository<T> where T : class
{
    public ICollection<T> FindAll();
    public T GetById(int id);
    public T Adicionar(T _obj);
    public T Atualizar(int id, T _obj);
    public T Excluir(int id);

}
