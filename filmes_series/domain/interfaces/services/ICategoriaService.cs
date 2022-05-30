using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.services
{
    public interface ICategoriaService:IDisposable
    {
        public List<Categoria> ObterTodos();
        public Categoria ObterPorId(int id);
        public bool Adicionar(Categoria _obj);
        public bool Atualizar(int id, Categoria _obj);
        public bool Excluir(int id);
    }
}
