using filmes_series._base.baserepository;
using filmes_series._base.baseservice;
using filmes_series.Data.Repository;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;
using filmes_series.Domain.Entity;

namespace filmes_series.domain.service
{
    public class UserAppService :BaseService<UserApp>,IUserAppService
    {
        private readonly IUserAppRepository _repository;
        public UserAppService(IUserAppRepository repository):base(repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
          _repository.Dispose();
          GC.SuppressFinalize(this);
        }

        public UserApp ObterPorEmail(string email)
        {
           
            return _repository.ObterPorEmail(email);
        }
    }
}
