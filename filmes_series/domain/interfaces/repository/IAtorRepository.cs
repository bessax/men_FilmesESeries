using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.repository
{
    public interface IAtorRepository : IDisposable
    {
        public List<Ator> FindAll();
        public Ator GetById(int id); 
        public bool Adicionar(Ator _ator);
        public bool Atualizar(int id, Ator _ator);
        public bool Excluir(int id);
    }
}
