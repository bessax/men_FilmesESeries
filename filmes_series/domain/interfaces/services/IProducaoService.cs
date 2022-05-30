using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.services
{
    public interface IProducaoService: IDisposable
    {
        public List<Producao> ObterTodos();
        public Producao ObterPorId(int id);
        public bool Adicionar(Producao _obj);
        public bool Atualizar(int id, Producao _obj);
        public bool Excluir(int id);
    }
}
