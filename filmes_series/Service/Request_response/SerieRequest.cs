using filmes_series.service.request_response;

namespace filmes_series.Service.Request_response
{
    public class SerieRequest : ProducaoRequestResponse
    {
        public SerieRequest()
        {
            this.Categoria = new CategoriaRequest();
            this.ElencoSerie = new List<AtorRequest>();
        }
        
        public int? Temporadas { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public virtual CategoriaRequest Categoria { get; set; }
        public virtual ICollection<AtorRequest> ElencoSerie { get; set; }
    }
}
