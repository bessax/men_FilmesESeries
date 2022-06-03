using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;

namespace filmes_series.service.appService
{
    public class AtorProducaoAppService:IAtorProducaoAppService
    {
        private readonly IAtorProducaoService _service;
        private readonly IMapper _mapper;
        public AtorProducaoAppService(IAtorProducaoService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public AtorProducaoResponse Adicionar(AtorProducaoRequest _atorproducao)
        {
            var retorno = _service.Adicionar(_mapper.Map<AtorProducaoRequest, AtorProducao>(_atorproducao));
            return _mapper.Map<AtorProducao, AtorProducaoResponse>(retorno);
        }

        public AtorProducaoResponse Atualizar(int id, AtorProducaoRequest _atorproducao)
        {
            var retorno = _service.Atualizar(id,_mapper.Map<AtorProducaoRequest, AtorProducao>(_atorproducao));
            return _mapper.Map<AtorProducao, AtorProducaoResponse>(retorno);
        }

        public AtorProducaoResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<AtorProducao, AtorProducaoResponse>(retorno);
            
        }

        public AtorProducaoResponse ObterPorIdDTO(int id)
        {
            return _mapper.Map<AtorProducao, AtorProducaoResponse>(_service.ObterPorId(id));
        }
        public List<AtorProducaoResponse> ObterTodosDTO()
        {
            var atores = _service.ObterTodos();
            List<AtorProducaoResponse> atoresDTO = _mapper.Map<List<AtorProducao>, List<AtorProducaoResponse>>(atores);
            return atoresDTO;
        }
    }
}
