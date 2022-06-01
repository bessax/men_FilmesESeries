using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface IProducaoAppService: IDisposable
    {
        public List<ProducaoRequest> ObterTodosDTO();
        public ProducaoRequest ObterPorIdDTO(int id);
        public bool Adicionar(ProducaoRequest _obj);
        public bool Atualizar(int id, ProducaoRequest _obj);
        public bool ExcluirDTO(int id);
    }
}
