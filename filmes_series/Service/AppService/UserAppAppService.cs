using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.Domain.Entity;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;

namespace filmes_series.service.appService
{
    public class UserAppAppService: IUserAppAppService
    {
        private readonly IUserAppService _service;
        private readonly IMapper _mapper;
        public UserAppAppService(IUserAppService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public UserAppResponse Adicionar(UserAppRequest _userapp)
        {
            var retorno = _service.Adicionar(_mapper.Map<UserAppRequest, UserApp>(_userapp));
            return _mapper.Map<UserApp,UserAppResponse>(retorno);
        }

        public UserAppResponse Atualizar(int id, UserAppRequest _userapp)
        {
            var retorno = _service.Atualizar(id,_mapper.Map<UserAppRequest, UserApp>(_userapp));
            return _mapper.Map<UserApp, UserAppResponse>(retorno);
        }

        public UserAppResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<UserApp, UserAppResponse>(retorno);
        }

        public UserAppResponse ObterPorIdDTO(int id)
        {
            var retorno = _service.ObterPorId(id);
            return _mapper.Map<UserApp, UserAppResponse>(retorno);
        }
        public List<UserAppResponse> ObterTodosDTO()
        {
            var objs = _service.ObterTodos();            
            List <UserAppResponse> userAppResponses = _mapper.Map<List<UserApp>, List<UserAppResponse>>(objs);
            return userAppResponses;
        }

        public UserAppResponse ObterPorEmail(string email)
        {
            var retorno = _service.ObterPorEmail(email);
            return _mapper.Map<UserApp, UserAppResponse>(retorno);
        }
    }
}
