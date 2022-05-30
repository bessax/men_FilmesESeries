using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.repository
{
    public interface ICategoriaRepository : IDisposable
    {
        public Categoria GetById(int id);
        public bool Adicionar(Categoria _categoria);
        public bool Atualizar(int id, Categoria _categoria);
        public bool Excluir(int id);

        public List<Categoria> FindAll();
    }
}
