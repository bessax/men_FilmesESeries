using filmes_series.service.request_response;

namespace filmes_series.Service.Request_response
{
    public class FilmeRequest: ProducaoRequestResponse
    {
        public FilmeRequest()
        {
            this.Categoria = new CategoriaRequest();
            this.ElencoFilme = new List<AtorRequest>();
        }
        public  virtual CategoriaRequest Categoria { get; set; }
        public virtual ICollection<AtorRequest> ElencoFilme { get; set; }
    }
}
