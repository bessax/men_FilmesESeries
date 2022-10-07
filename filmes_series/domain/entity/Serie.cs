using System.ComponentModel.DataAnnotations;

namespace filmes_series.domain.entity;

public class Serie:Producao
{
    public Serie()
    {
        this.Categoria = new Categoria();
        this.ElencoSerie = new List<Ator>();
    }
    [StringLength(255)]
    public int? Temporadas { get; set; }
    public DateTime? DataEncerramento { get; set; }
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
    public virtual ICollection<Ator> ElencoSerie { get; set; }
}
