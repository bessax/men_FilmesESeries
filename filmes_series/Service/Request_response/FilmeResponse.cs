using filmes_series.service.request_response;

namespace filmes_series.Service.Request_response
{
    public class FilmeResponse : ProducaoRequestResponse
    {
        public FilmeResponse()
        {
            
            this.ElencoFilme = new List<AtorResponse>();
        }

        public virtual CategoriaResponse Categoria { get; set; }
        public virtual ICollection<AtorResponse> ElencoFilme { get; set; }
    }
}
