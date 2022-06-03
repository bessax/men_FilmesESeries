using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface IProducaoAppService: IDisposable
    {
        public List<ProducaoResponse> ObterTodosDTO();
        public ProducaoResponse ObterPorIdDTO(int id);
        public ProducaoResponse Adicionar(ProducaoRequest _obj);
        public ProducaoResponse Atualizar(int id, ProducaoRequest _obj);
        public ProducaoResponse ExcluirDTO(int id);
    }
}
