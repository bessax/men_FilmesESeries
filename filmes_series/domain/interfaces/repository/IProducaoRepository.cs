using filmes_series._base.baserepository;
using filmes_series.domain.entity;

namespace filmes_series.domain.interfaces.repository
{
    public interface IProducaoRepository: IBaseRepository<Producao>, IDisposable
    {
    }
}
