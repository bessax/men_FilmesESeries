using System.ComponentModel.DataAnnotations;

namespace filmes_series.domain.entity;

public class Serie:Producao
{
    [StringLength(255)]
    public int? Temporadas { get; set; }
    public DateTime? DataEncerramento { get; set; }
}
