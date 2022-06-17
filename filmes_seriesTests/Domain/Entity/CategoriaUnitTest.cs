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
    public class CategoriaUnitTest
    {
        [Fact]
        public void CategoriaTemQueSerValida()
        {
            var _categoria = new CategoriaBuilder().Build();
            var validador = new CategoriaModelValidator();
            var result = validador.Validate(_categoria);
            Assert.True(result.IsValid);
        }

        [Fact]
        public void NomeCategoriaInvalido()
        {
            var _categoria = new CategoriaBuilder().Build();
            _categoria.Nome = String.Empty;
            var validador = new CategoriaModelValidator();
            var result = validador.Validate(_categoria);

            Assert.True(!result.IsValid);
            Assert.Contains(result.Errors, x => x.ErrorMessage == "Nome da categoria não pode ser vazio");
            Assert.Contains(result.Errors, x => x.ErrorMessage == "Mímimo de 5 caracteres na descrição.");
        }
    }
}
