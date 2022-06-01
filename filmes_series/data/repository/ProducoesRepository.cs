using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;


namespace filmes_series.data.repository
{
    public class ProducoesRepository : BaseRepository<Producao>, IProducaoRepository
    {
        private readonly AppDbContext _context;

        public ProducoesRepository()
        {
            _context = new AppDbContext();
        }
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
