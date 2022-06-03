using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface IAtorProducaoAppService: IDisposable
    {
        public List<AtorProducaoResponse> ObterTodosDTO();
        public AtorProducaoResponse ObterPorIdDTO(int id);
        public AtorProducaoResponse Adicionar(AtorProducaoRequest _ator);
        public AtorProducaoResponse Atualizar(int id, AtorProducaoRequest _ator);
        public AtorProducaoResponse ExcluirDTO(int id);
    }
}
