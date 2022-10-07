using System.ComponentModel.DataAnnotations;

namespace filmes_series.domain.entity;

public class Filme:Producao
{
    public Filme()
    {
        this.Categoria = new Categoria();
        this.ElencoFilme = new List<Ator>();
    }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
    public virtual ICollection<Ator> ElencoFilme { get; set; }

}
