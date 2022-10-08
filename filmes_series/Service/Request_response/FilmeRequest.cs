using filmes_series.service.request_response;
using Newtonsoft.Json;

namespace filmes_series.Service.Request_response
{
    public class FilmeRequest: ProducaoRequestResponse
    {
        public FilmeRequest()
        {    
            this.ElencoFilme = new List<AtorRequest>();
        }
        public  int CategoriaId { get; set; }

        [JsonIgnore]
        public virtual ICollection<AtorRequest> ElencoFilme { get; set; }
    }
}
