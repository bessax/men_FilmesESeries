using filmes_series.Service.Request_response;
using System.Text.Json.Serialization;

namespace filmes_series.service.request_response
{
    public class AtorRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //[JsonIgnore]
        //public virtual ICollection<FilmeRequest> ProducaoFilme { get; set; }
        //[JsonIgnore]
        //public virtual ICollection<SerieRequest> ProducaoSerie { get; set; }

    }
}
