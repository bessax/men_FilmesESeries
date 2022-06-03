using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;

namespace filmes_series.service.appService
{
    public class AtorAppService:IAtorAppService
    {
        private readonly IAtorService _service;
        private readonly IMapper _mapper;
        public AtorAppService(IAtorService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public AtorResponse Adicionar(AtorRequest _ator)
        {
            var retorno = _service.Adicionar(_mapper.Map<AtorRequest, Ator>(_ator));
            return _mapper.Map<Ator,AtorResponse>(retorno);
        }

        public AtorResponse Atualizar(int id, AtorRequest _ator)
        {
            var retorno = _service.Atualizar(id,_mapper.Map<AtorRequest, Ator>(_ator));
            return _mapper.Map<Ator, AtorResponse>(retorno);
        }

        public AtorResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<Ator, AtorResponse>(retorno);
        }

        public AtorResponse ObterPorIdDTO(int id)
        {
            var retorno = _service.ObterPorId(id);
            return _mapper.Map<Ator, AtorResponse>(retorno);
        }
        public List<AtorResponse> ObterTodosDTO()
        {
            var atores = _service.ObterTodos();
            List<AtorResponse> atoresDTO = _mapper.Map<List<Ator>, List<AtorResponse>>(atores);
            return atoresDTO;
        }
    }
}
