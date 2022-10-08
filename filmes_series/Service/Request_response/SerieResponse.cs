using filmes_series.service.request_response;

namespace filmes_series.Service.Request_response
{
    public class SerieResponse : ProducaoRequestResponse
    {
        public SerieResponse()
        {
            this.Categoria = new CategoriaResponse();
            this.ElencoSerie = new List<AtorResponse>();
        }
        
        public int? Temporadas { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public virtual CategoriaResponse Categoria { get; set; }
        public virtual ICollection<AtorResponse> ElencoSerie { get; set; }
    }
}
