using filmes_series._base.baseservice;
using filmes_series.Domain.Entity;

namespace filmes_series.domain.interfaces.services
{
    public interface IUserAppService:IBaseService<UserApp>,IDisposable
    {
        UserApp ObterPorEmail(string email);
    }
}
