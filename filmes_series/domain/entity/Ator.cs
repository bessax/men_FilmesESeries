﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace filmes_series.domain.entity;

public class Ator
{
    public Ator()
    {
        this.Producoes = new List<Producao>();
        
    }
    public int Id { get; set; }
    [StringLength(255)]
    public string Nome { get; set; }        
    public virtual List<Producao> Producoes { get; set; }

    public ICollection<AtorProducao> AtorProducao { get; set; }

}
