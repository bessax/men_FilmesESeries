using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface IUserAppAppService:IDisposable
    {
        public ICollection<UserAppResponse> ObterTodosDTO();
        public UserAppResponse ObterPorIdDTO(int id);
        public UserAppResponse ObterPorEmail(string email);
        public UserAppResponse Adicionar(UserAppRequest _userapp);
        public UserAppResponse Atualizar(int id, UserAppRequest _userapp);
       
    }
}
