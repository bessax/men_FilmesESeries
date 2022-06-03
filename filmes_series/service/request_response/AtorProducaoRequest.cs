using System.Text.Json.Serialization;

namespace filmes_series.service.request_response
{
    public class AtorProducaoRequest
    {
        public int Id { get; set; }
        public int ElencoId { get; set; }
        public int ProducoesId { get; set; }

        [JsonIgnore]
        public AtorRequest ElencoDTO { get; set; }
        [JsonIgnore]
        public ProducaoRequest ProducoesDTO { get; set; }
    }
}
