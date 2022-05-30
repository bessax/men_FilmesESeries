using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.dto;
using filmes_series.service.interfaces;

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
                   cfg.CreateMap<Producao, ProducaoDTO>().ReverseMap());
            _mapper = new(config);
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Adicionar(ProducaoDTO _Producao)
        {
            return _service.Adicionar(_mapper.Map<ProducaoDTO, Producao>(_Producao));
        }

        public bool Atualizar(int id, ProducaoDTO _Producao)
        {
            return _service.Atualizar(id, _mapper.Map<ProducaoDTO, Producao>(_Producao));
        }

        public bool ExcluirDTO(int id)
        {
            return _service.Excluir(id);
        }

        public ProducaoDTO ObterPorIdDTO(int id)
        {
            return _mapper.Map<Producao, ProducaoDTO>(_service.ObterPorId(id));
        }
        public List<ProducaoDTO> ObterTodosDTO()
        {
            var producoes = _service.ObterTodos();
            List<ProducaoDTO> producoesDTO = _mapper.Map<List<Producao>, List<ProducaoDTO>>(producoes);
            return producoesDTO;
        }


    }
}
