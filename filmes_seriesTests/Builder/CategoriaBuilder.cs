using filmes_series.domain.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmes_seriesTests.Builder;

public class CategoriaBuilder
{
    public Categoria Build()
    {
        return new Categoria()
        {
            Id = 1,
            Nome = "Terror",
            Descricao = "Terror ou horror é um gênero literário, " +
            "cinematográfico ou musical, que está sempre muito " +
            "ligado à fantasia e à ficção especulativa," +
            "e é criado com intuito de causar medo, aterrorizar. "
        };
    }
}

