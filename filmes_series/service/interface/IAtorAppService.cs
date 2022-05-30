using filmes_series.service.dto;

namespace filmes_series.service.interfaces
{
    public interface IAtorAppService:IDisposable
    {
        public List<AtorDTO> ObterTodosDTO();
        public AtorDTO ObterPorIdDTO(int id);
        public bool Adicionar(AtorDTO _ator);
        public bool Atualizar(int id, AtorDTO _ator);
        public bool ExcluirDTO(int id);
    }
}
