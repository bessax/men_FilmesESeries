using System.ComponentModel.DataAnnotations;

namespace filmes_series.domain.entity;

public abstract class Producao
{
    public Producao()
    {
     
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
      
}
