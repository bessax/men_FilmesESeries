using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;

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
                   cfg.CreateMap<Categoria, CategoriaRequest>().ReverseMap());
            _mapper = new(config);
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Adicionar(CategoriaRequest _Categoria)
        {
            return _service.Adicionar(_mapper.Map<CategoriaRequest, Categoria>(_Categoria));
        }

        public bool Atualizar(int id, CategoriaRequest _Categoria)
        {
            return _service.Atualizar(id, _mapper.Map<CategoriaRequest, Categoria>(_Categoria));
        }

        public bool ExcluirDTO(int id)
        {
            return _service.Excluir(id);
        }

        public CategoriaRequest ObterPorIdDTO(int id)
        {
            return _mapper.Map<Categoria, CategoriaRequest>(_service.ObterPorId(id));
        }
        public List<CategoriaRequest> ObterTodosDTO()
        {
            var categorias = _service.ObterTodos();
            List<CategoriaRequest> categoriasDTO = _mapper.Map<List<Categoria>, List<CategoriaRequest>>(categorias);
            return categoriasDTO;
        }

      
    }
}
