﻿namespace filmes_series.service.request_response
{
    public class ProducaoRequest
    {
        public int Id { get; set; }     
        public string Nome { get; set; }       
        public string Classificacao { get; set; }
        public string Diretor { get; set; }
        public string Estudio { get; set; }
        public DateTime? DataLancamento { get; set; }
       
    }
}
