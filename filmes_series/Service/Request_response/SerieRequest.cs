using filmes_series.service.request_response;
using System.Text.Json.Serialization;

namespace filmes_series.Service.Request_response
{
    public class SerieRequest : ProducaoRequestResponse
    {
        public SerieRequest()
        {     
           this.ElencoSerie = new List<AtorRequest>();
        }
        
        public int? Temporadas { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public virtual ICollection<AtorRequest> ElencoSerie { get; set; }
    }
}
