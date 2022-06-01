namespace filmes_series.service.request_response
{
    public class AtorRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<ProducaoRequest> ProducoesDTO { get; set; }
    }
}
