using filmes_series.domain.entity;
using FluentValidation;

namespace filmes_series.Validator
{
    public class AtorModelValidator:AbstractValidator<Ator>
    {
        public AtorModelValidator()
        {
            RuleFor(a => a.Nome).NotEmpty().WithMessage("Nome não pode ser vazio").
                MinimumLength(3).WithMessage("Tamanho mínimo 3 caracteres");
           
        }
    }
}
