using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface ICategoriaAppService: IDisposable
    {
        public List<CategoriaRequest> ObterTodosDTO();
        public CategoriaRequest ObterPorIdDTO(int id);
        public bool Adicionar(CategoriaRequest _obj);
        public bool Atualizar(int id, CategoriaRequest _obj);
        public bool ExcluirDTO(int id);
    }
}
