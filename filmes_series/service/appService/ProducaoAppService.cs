using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;

namespace filmes_series.service.appService
{
    public class ProducaoAppService : IProducaoAppService
    {
        private readonly IProducaoService _service;
        private readonly IMapper _mapper;
        public ProducaoAppService(IProducaoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public ProducaoResponse Adicionar(ProducaoRequest _Producao)
        {   
            var retorno = _service.Adicionar(_mapper.Map<ProducaoRequest, Producao>(_Producao));
            return _mapper.Map<Producao,ProducaoResponse>(retorno);
        }

        public ProducaoResponse Atualizar(int id, ProducaoRequest _Producao)
        {
            var retorno = _service.Atualizar(id,_mapper.Map<ProducaoRequest, Producao>(_Producao));
            return _mapper.Map<Producao, ProducaoResponse>(retorno);
        }

        public ProducaoResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<Producao, ProducaoResponse>(retorno);
        }

        public ProducaoResponse ObterPorIdDTO(int id)
        {
            var retorno = _service.ObterPorId(id);
            return _mapper.Map<Producao, ProducaoResponse>(retorno);
        }
        public List<ProducaoResponse> ObterTodosDTO()
        {
            var producoes = _service.ObterTodos();
            List<ProducaoResponse> producoesDTO = _mapper.Map<List<Producao>, List<ProducaoResponse>>(producoes);
            return producoesDTO;
        }


    }
}
