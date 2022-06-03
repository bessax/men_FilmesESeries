using System.Text.Json.Serialization;

namespace filmes_series.service.request_response
{
    public class AtorProducaoResponse
    {
        public int Id { get; set; }
        public int ElencoId { get; set; }
        public int ProducoesId { get; set; }    
        public AtorResponse ElencoDTO { get; set; }     
        public ProducaoResponse ProducoesDTO { get; set; }
    }
}
