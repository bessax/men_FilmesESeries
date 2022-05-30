using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.services
{
    public interface IAtorService: IDisposable
    {
        public List<Ator> ObterTodos();
        public Ator ObterPorId(int id);
        public bool Adicionar(Ator _ator);
        public bool Atualizar(int id, Ator _ator);
        public bool Excluir(int id);
    }
}
