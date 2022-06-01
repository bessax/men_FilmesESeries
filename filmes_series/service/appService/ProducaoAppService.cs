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
        private readonly Mapper _mapper;
        public ProducaoAppService(IProducaoService service)
        {
            _service = service;
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<Producao, ProducaoRequest>().ReverseMap());
            _mapper = new(config);
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Adicionar(ProducaoRequest _Producao)
        {
            return _service.Adicionar(_mapper.Map<ProducaoRequest, Producao>(_Producao));
        }

        public bool Atualizar(int id, ProducaoRequest _Producao)
        {
            return _service.Atualizar(id, _mapper.Map<ProducaoRequest, Producao>(_Producao));
        }

        public bool ExcluirDTO(int id)
        {
            return _service.Excluir(id);
        }

        public ProducaoRequest ObterPorIdDTO(int id)
        {
            return _mapper.Map<Producao, ProducaoRequest>(_service.ObterPorId(id));
        }
        public List<ProducaoRequest> ObterTodosDTO()
        {
            var producoes = _service.ObterTodos();
            List<ProducaoRequest> producoesDTO = _mapper.Map<List<Producao>, List<ProducaoRequest>>(producoes);
            return producoesDTO;
        }


    }
}
