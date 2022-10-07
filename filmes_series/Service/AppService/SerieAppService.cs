using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.services;
using filmes_series.service.interfaces;
using filmes_series.Service.Request_response;

namespace Series_series.service.appService
{
    public class SerieAppService : ISerieAppService
    {
        private readonly ISerieService _service;
        private readonly IMapper _mapper;
        public SerieAppService(ISerieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public SerieResponse Adicionar(SerieRequest _Serie)
        {
            var retorno = _service.Adicionar(_mapper.Map<SerieRequest, Serie>(_Serie));
            return _mapper.Map<Serie, SerieResponse>(retorno);
        }

        public SerieResponse Atualizar(int id, SerieRequest _Serie)
        {
            var retorno = _service.Atualizar(id, _mapper.Map<SerieRequest, Serie>(_Serie));
            return _mapper.Map<Serie, SerieResponse>(retorno);
        }

        public SerieResponse ExcluirDTO(int id)
        {
            var retorno = _service.Excluir(id);
            return _mapper.Map<Serie, SerieResponse>(retorno);
        }

        public SerieResponse ObterPorIdDTO(int id)
        {
            var retorno = _service.ObterPorId(id);
            return _mapper.Map<Serie, SerieResponse>(retorno);
        }
        public List<SerieResponse> ObterTodosDTO()
        {
            var Seriees = _service.ObterTodos();
            List<SerieResponse> SerieesDTO = _mapper.Map<List<Serie>, List<SerieResponse>>(Seriees);
            return SerieesDTO;
        }
    }
}
