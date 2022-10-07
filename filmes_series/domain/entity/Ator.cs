using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace filmes_series.domain.entity;

public class Ator
{
    public int Id { get; set; }
    [StringLength(255)]
    public string Nome { get; set; }        
    public virtual ICollection<Filme> ProducaoFilme{ get; set; }
    public virtual ICollection<Serie> ProducaoSerie { get; set; }

}
