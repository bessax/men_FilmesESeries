using filmes_series.domain.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmes_seriesTests.Builder
{
    public class AtorBuilder
    {
        public Ator Build()
        {
            return new Ator()
            {
                Id = 1,
                Nome = "André"              

            };
        }
    }
}
