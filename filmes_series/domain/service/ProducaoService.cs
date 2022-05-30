using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;

namespace filmes_series.domain.service
{
    public class ProducaoService:IProducaoService
    {
        private readonly IProducaoRepository _repository;
        public ProducaoService(IProducaoRepository repository)
        {
            _repository = repository;
        }
        public bool Adicionar(Producao _obj)
        {
            return _repository.Adicionar(_obj);
        }

        public bool Atualizar(int id, Producao _obj)
        {
            return _repository.Atualizar(id, _obj);
        }

        public bool Excluir(int id)
        {
            return _repository.Excluir(id);
        }

        public Producao ObterPorId(int id)
        {
            return _repository.GetById(id);
        }

        public List<Producao> ObterTodos()
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
