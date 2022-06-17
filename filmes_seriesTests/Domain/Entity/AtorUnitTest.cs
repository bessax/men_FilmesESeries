using filmes_series.Validator;
using filmes_seriesTests.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace filmes_seriesTests.Domain.Entity
{
    public class AtorUnitTest
    { 
        [Fact]
        public void AtorTemQueSerValido()
        {
            var _ator = new AtorBuilder().Build();

            var validador = new AtorModelValidator();
            var result = validador.Validate(_ator);

            Assert.True(result.IsValid);
        }
        
        [Fact]
        public void NomeAtorInvalido()
        {
            var _ator = new AtorBuilder().Build();
            _ator.Nome = String.Empty;
            var validador = new AtorModelValidator();
            var result = validador.Validate(_ator);

            Assert.True(!result.IsValid);
            Assert.Contains(result.Errors,x=>x.ErrorMessage == "Nome não pode ser vazio");
            Assert.Contains(result.Errors, x => x.ErrorMessage == "Tamanho mínimo 3 caracteres");
        }
    }
}
