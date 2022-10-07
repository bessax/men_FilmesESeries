namespace filmes_series.Service.Request_response
{
    public abstract class ProducaoRequestResponse
    {
        public int Id { get; set; }     
        public string Nome { get; set; }      
        public string Classificacao { get; set; }     
        public string Diretor { get; set; }       
        public string Estudio { get; set; }
        public DateTime? DataLancamento { get; set; }

    }
}
