using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.dto;
using filmes_series.service.interfaces;

namespace filmes_series.service.appService
{
    public class CategoriaAppService : ICategoriaAppService
    {
        private readonly ICategoriaService _service;
        private readonly Mapper _mapper;
        public CategoriaAppService(ICategoriaService service)
        {
            _service = service;
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<Categoria, CategoriaDTO>().ReverseMap());
            _mapper = new(config);
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Adicionar(CategoriaDTO _Categoria)
        {
            return _service.Adicionar(_mapper.Map<CategoriaDTO, Categoria>(_Categoria));
        }

        public bool Atualizar(int id, CategoriaDTO _Categoria)
        {
            return _service.Atualizar(id, _mapper.Map<CategoriaDTO, Categoria>(_Categoria));
        }

        public bool ExcluirDTO(int id)
        {
            return _service.Excluir(id);
        }

        public CategoriaDTO ObterPorIdDTO(int id)
        {
            return _mapper.Map<Categoria, CategoriaDTO>(_service.ObterPorId(id));
        }
        public List<CategoriaDTO> ObterTodosDTO()
        {
            var categorias = _service.ObterTodos();
            List<CategoriaDTO> categoriasDTO = _mapper.Map<List<Categoria>, List<CategoriaDTO>>(categorias);
            return categoriasDTO;
        }

      
    }
}
