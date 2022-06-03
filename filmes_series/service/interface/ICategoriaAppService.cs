using filmes_series.service.request_response;

namespace filmes_series.service.interfaces
{
    public interface ICategoriaAppService: IDisposable
    {
        public List<CategoriaResponse> ObterTodosDTO();
        public CategoriaResponse ObterPorIdDTO(int id);
        public CategoriaResponse Adicionar(CategoriaRequest _obj);
        public CategoriaResponse Atualizar(int id, CategoriaRequest _obj);
        public CategoriaResponse ExcluirDTO(int id);
    }
}
