using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.mapper;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;

namespace filmes_series.service.appService
{
    public class AtorAppService:IAtorAppService
    {
        private readonly IAtorService _service;
        private readonly Mapper _mapper;
        public AtorAppService(IAtorService service)
        {
            _service = service;
            _mapper = new(AutoMapperConfig<Ator, AtorRequest>.ConfigureMapper());
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Adicionar(AtorRequest _ator)
        {
            return _service.Adicionar(_mapper.Map<AtorRequest, Ator>(_ator));
        }

        public bool Atualizar(int id, AtorRequest _ator)
        {
            return _service.Atualizar(id,_mapper.Map<AtorRequest, Ator>(_ator));
        }

        public bool ExcluirDTO(int id)
        {
            return _service.Excluir(id);
        }

        public AtorRequest ObterPorIdDTO(int id)
        {
            return _mapper.Map<Ator, AtorRequest>(_service.ObterPorId(id));
        }
        public List<AtorRequest> ObterTodosDTO()
        {
            var atores = _service.ObterTodos();
            List<AtorRequest> atoresDTO = _mapper.Map<List<Ator>, List<AtorRequest>>(atores);
            return atoresDTO;
        }
    }
}
