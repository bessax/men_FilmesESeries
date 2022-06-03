

namespace filmes_series.domain.entity
{
   
    public class AtorProducao
    {       
        public int Id { get; set; }
        public int ElencoId { get; set; }  
        public virtual Ator Elenco { get; set; }
        public int ProducoesId { get; set; }
        public virtual Producao Producoes { get; set; }
    }
}
