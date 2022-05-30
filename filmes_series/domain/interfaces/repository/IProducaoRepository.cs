using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.repository
{
    public interface IProducaoRepository : IDisposable
    {
        public Producao GetById(int id);
        public bool Adicionar(Producao _producao);
        public bool Atualizar(int id, Producao _producao);
        public bool Excluir(int id);
        public List<Producao> FindAll();
    }
}
