using System.ComponentModel.DataAnnotations;

namespace filmes_series.domain.entity;

    public class Categoria
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string? Nome { get; set; }
        [StringLength(255)]
        public string? Descricao { get; set; }
    }

