using filmes_series.service.request_response;
using filmes_series.Service.Request_response;

namespace filmes_series.service.interfaces
{
    public interface ISerieAppService: IDisposable
    {
        public List<SerieResponse> ObterTodosDTO();
        public SerieResponse ObterPorIdDTO(int id);
        public SerieResponse Adicionar(SerieRequest _obj);
        public SerieResponse Atualizar(int id, SerieRequest _obj);
        public SerieResponse ExcluirDTO(int id);
    }
}
