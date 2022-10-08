using filmes_series.service.request_response;
using filmes_series.Service.Request_response;

namespace filmes_series.service.interfaces
{
    public interface IFilmeAppService: IDisposable
    {
        public ICollection<FilmeResponse> ObterTodosDTO();
        public FilmeResponse ObterPorIdDTO(int id);
        public FilmeResponse Adicionar(FilmeRequest _obj);
        public FilmeResponse Atualizar(int id, FilmeRequest _obj);
        public FilmeResponse ExcluirDTO(int id);
    }
}
