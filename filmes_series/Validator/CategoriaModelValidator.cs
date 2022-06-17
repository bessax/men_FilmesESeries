using filmes_series.domain.entity;
using FluentValidation;

namespace filmes_series.Validator
{
    public class CategoriaModelValidator:AbstractValidator<Categoria>
    {
        public CategoriaModelValidator()
        {
            RuleFor(c => c.Descricao).NotEmpty().WithMessage("Descrição da categoria não pode ser vazio")
                .MinimumLength(5).WithMessage("Mímimo de 5 caracteres na descrição.")
                .MaximumLength(200).WithMessage("Máximo de 100 caracteres.");

            RuleFor(c => c.Nome).NotEmpty().WithMessage("Nome da categoria não pode ser vazio")
                .MinimumLength(5).WithMessage("Mímimo de 5 caracteres na descrição.")
                .MaximumLength(200).WithMessage("Máximo de 100 caracteres.");
        }
    }
}
