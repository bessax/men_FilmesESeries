using System.Text.Json.Serialization;

namespace filmes_series.service.request_response
{
    public class ProducaoResponse
    {
        public int Id { get; set; }     
        public string Nome { get; set; }       
        public string Classificacao { get; set; }
        public string Diretor { get; set; }
        public string Estudio { get; set; }
        public DateTime? DataLancamento { get; set; }

        //public virtual List<AtorRequest> ElencoDTO { get; set; }
        public virtual List<AtorProducaoRequest> ElencoDTO { get; set; }
        public virtual List<CategoriaRequest> CategoriasDTO { get; set; }
    }
}
