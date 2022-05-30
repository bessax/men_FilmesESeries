using filmes_series.domain.entity;
using filmes_series.service.dto;

namespace filmes_series.service.interfaces
{
    public interface ICategoriaAppService: IDisposable
    {
        public List<CategoriaDTO> ObterTodosDTO();
        public CategoriaDTO ObterPorIdDTO(int id);
        public bool Adicionar(CategoriaDTO _obj);
        public bool Atualizar(int id, CategoriaDTO _obj);
        public bool ExcluirDTO(int id);
    }
}
