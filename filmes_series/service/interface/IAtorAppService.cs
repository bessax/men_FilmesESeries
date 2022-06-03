using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface IAtorAppService:IDisposable
    {
        public List<AtorResponse> ObterTodosDTO();
        public AtorResponse ObterPorIdDTO(int id);
        public AtorResponse Adicionar(AtorRequest _ator);
        public AtorResponse Atualizar(int id, AtorRequest _ator);
        public AtorResponse ExcluirDTO(int id);
    }
}
