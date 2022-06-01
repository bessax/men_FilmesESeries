using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface IAtorAppService:IDisposable
    {
        public List<AtorRequest> ObterTodosDTO();
        public AtorRequest ObterPorIdDTO(int id);
        public bool Adicionar(AtorRequest _ator);
        public bool Atualizar(int id, AtorRequest _ator);
        public bool ExcluirDTO(int id);
    }
}
