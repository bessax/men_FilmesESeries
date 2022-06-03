using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filmes_series.domain.entity
{
    [Table("AtorProducao")]
    public class AtorProducao
    {
        [Key]
        public int Id { get; set; }
        public int ElencoId { get; set; }  
        public virtual Ator Elenco { get; set; }
        public int ProducoesId { get; set; }
        public virtual Producao Producoes { get; set; }
    }
}
