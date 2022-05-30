using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;


namespace filmes_series.domain.service
{
    public class AtorService : IAtorService
    {
        private readonly IAtorRepository _repository;
        public AtorService(IAtorRepository repository)
        {
            _repository = repository;
        }
        public bool Adicionar(Ator _ator)
        {
            return _repository.Adicionar(_ator);
        }

        public bool Atualizar(int id, Ator _ator)
        {
            return _repository.Atualizar(id, _ator);
        }      

        public bool Excluir(int id)
        {
            return _repository.Excluir(id);
        }

        public Ator ObterPorId(int id)
        {
            return _repository.GetById(id);
        }

        public List<Ator> ObterTodos()
        {
            return _repository.FindAll();
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
