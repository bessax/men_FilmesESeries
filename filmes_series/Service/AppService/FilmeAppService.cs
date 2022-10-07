using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using filmes_series.Service.Request_response;

namespace filmes_series.service.appService
{
    public class FilmeAppService : IFilmeAppService
    {
        private readonly IFilmeService _service;
        private readonly IMapper _mapper;
        public FilmeAppService(IFilmeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public FilmeResponse Adicionar(FilmeRequest _Filme)
        {
            var retorno = _service.Adicionar(_mapper.Map<FilmeRequest, Filme>(_Filme));
            return _mapper.Map<Filme, FilmeResponse>(retorno);
        }

        public FilmeResponse Atualizar(int id, FilmeRequest _Filme)
        {
            var retorno = _service.Atualizar(id, _mapper.Map<FilmeRequest, Filme>(_Filme));
            return _mapper.Map<Filme, FilmeResponse>(retorno);
        }

        public FilmeResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<Filme, FilmeResponse>(retorno);
        }

        public FilmeResponse ObterPorIdDTO(int id)
        {
            var retorno = _service.ObterPorId(id);
            return _mapper.Map<Filme, FilmeResponse>(retorno);
        }
        public List<FilmeResponse> ObterTodosDTO()
        {
            var Filmees = _service.ObterTodos();
            List<FilmeResponse> FilmeesDTO = _mapper.Map<List<Filme>, List<FilmeResponse>>(Filmees);
            return FilmeesDTO;
        }
    }
}
