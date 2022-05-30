namespace filmes_series.service.dto
{
    public class AtorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<ProducaoDTO> ProducoesDTO { get; set; }
    }
}
