using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.dto;
using filmes_series.service.interfaces;

namespace filmes_series.service.appService
{
    public class AtorAppService:IAtorAppService
    {
        private readonly IAtorService _service;
        private readonly Mapper _mapper;
        public AtorAppService(IAtorService service)
        {
            _service = service;
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<Ator, AtorDTO>().ReverseMap());
            _mapper = new(config);
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Adicionar(AtorDTO _ator)
        {
            return _service.Adicionar(_mapper.Map<AtorDTO, Ator>(_ator));
        }

        public bool Atualizar(int id, AtorDTO _ator)
        {
            return _service.Atualizar(id,_mapper.Map<AtorDTO, Ator>(_ator));
        }

        public bool ExcluirDTO(int id)
        {
            return _service.Excluir(id);
        }

        public AtorDTO ObterPorIdDTO(int id)
        {
            return _mapper.Map<Ator, AtorDTO>(_service.ObterPorId(id));
        }
        public List<AtorDTO> ObterTodosDTO()
        {
            var atores = _service.ObterTodos();
            List<AtorDTO> atoresDTO = _mapper.Map<List<Ator>, List<AtorDTO>>(atores);
            return atoresDTO;
        }
    }
}
