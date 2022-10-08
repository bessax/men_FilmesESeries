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
        private readonly IMapper _mapper;
        public CategoriaAppService(ICategoriaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public CategoriaResponse Adicionar(CategoriaRequest _Categoria)
        {
            var retorno = _service.Adicionar(_mapper.Map<CategoriaRequest, Categoria>(_Categoria));
            return _mapper.Map<Categoria,CategoriaResponse>(retorno);
        }

        public CategoriaResponse Atualizar(int id, CategoriaRequest _Categoria)
        {
            var retorno = _service.Atualizar(id,_mapper.Map<CategoriaRequest, Categoria>(_Categoria));
            return _mapper.Map<Categoria, CategoriaResponse>(retorno); 
        }

        public CategoriaResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<Categoria, CategoriaResponse>(retorno);
        }

        public CategoriaResponse ObterPorIdDTO(int id)
        {
            var retorno = _service.ObterPorId(id);
            return _mapper.Map<Categoria, CategoriaResponse>(retorno);
        }
        public ICollection<CategoriaResponse> ObterTodosDTO()
        {
            var categorias = _service.ObterTodos();
            ICollection<CategoriaResponse> categoriasDTO = _mapper.Map<ICollection<Categoria>, ICollection<CategoriaResponse>>(categorias);
            return categoriasDTO;
        }

      
    }
}
