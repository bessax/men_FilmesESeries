using filmes_series._base.baserepository;
using filmes_series.domain.entity;
using filmes_series.Domain.Entity;

namespace filmes_series.domain.interfaces.repository
{
    public interface IUserAppRepository :IBaseRepository<UserApp>,IDisposable
    {
        UserApp ObterPorEmail(string email);
    }
}
