using filmes_series.domain.entity;
using filmes_series.service.dto;

namespace filmes_series.service.interfaces
{
    public interface IProducaoAppService: IDisposable
    {
        public List<ProducaoDTO> ObterTodosDTO();
        public ProducaoDTO ObterPorIdDTO(int id);
        public bool Adicionar(ProducaoDTO _obj);
        public bool Atualizar(int id, ProducaoDTO _obj);
        public bool ExcluirDTO(int id);
    }
}
