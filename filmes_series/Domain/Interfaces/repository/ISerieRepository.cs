using filmes_series.domain.entity;
using filmes_series.filmes_series.Base.Baserepository;

namespace filmes_series.domain.interfaces.repository
{
    public interface ISerieRepository :IBaseRepository<Serie>,IDisposable
    {
   
    }
}
