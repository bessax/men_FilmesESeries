namespace filmes_series.service.dto
{
    public class ProducaoDTO
    {
        public int Id { get; set; }     
        public string Nome { get; set; }       
        public string Classificacao { get; set; }
        public string Diretor { get; set; }
        public string Estudio { get; set; }
        public DateTime? DataLancamento { get; set; }
        public virtual List<AtorDTO> ElencoDTO { get; set; }
        public virtual List<CategoriaDTO> CategoriasDTO { get; set; }
    }
}
