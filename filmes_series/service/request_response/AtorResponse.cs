﻿namespace filmes_series.service.request_response
{
    public class AtorResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<AtorProducaoResponse> ProducoesDTO { get; set; }
    }
}
