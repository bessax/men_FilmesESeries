using filmes_series._base.baserepository;
using filmes_series._base.baseservice;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;


namespace filmes_series.domain.service
{
    public class SerieService : BaseService<Serie>, ISerieService
    {
        private readonly ISerieRepository _repository;
        public SerieService(ISerieRepository repository) : base(repository)
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
