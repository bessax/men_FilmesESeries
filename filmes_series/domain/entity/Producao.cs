using System.ComponentModel.DataAnnotations;

namespace filmes_series.domain.entity;

public class Producao
{
    public Producao()
    {
        this.Categorias = new List<Categoria>();      ;
        // this.Elenco = new List<Ator>();
        this.AtorProducao = new List<AtorProducao>();

    }
    public int Id { get; set; }

    [StringLength(255)]
    public string Nome { get; set; }

    [StringLength(255)]
    public string Classificacao { get; set; }

    [StringLength(255)]
    public string Diretor { get; set; }

    [StringLength(255)]
    public string Estudio { get; set; }

    public DateTime? DataLancamento { get; set; }
    //public virtual List<Ator> Elenco { get; set; }
    public virtual List<Categoria> Categorias { get; set; }

    public List<AtorProducao> AtorProducao { get; set; }

}
