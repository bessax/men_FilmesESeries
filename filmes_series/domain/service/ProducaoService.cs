using filmes_series._base.baseservice;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;

namespace filmes_series.domain.service
{
    public class ProducaoService:BaseService<Producao>,IProducaoService
    {
        private readonly IProducaoRepository _repository;
        public ProducaoService(IProducaoRepository repository):base(repository)
        {
            _repository = repository;
        }       
        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
