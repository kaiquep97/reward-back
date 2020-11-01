using FluentValidation;
using Rewards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Validators
{
    public class CreateProductValidator: AbstractValidator<CreateProductViewModel>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.CategoryId)
                .GreaterThan(0)
                .WithMessage("Id da categoria não informado");

            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Nome não informado")
                .MaximumLength(100)
                .WithMessage("Nome deve ter até 100 caracteres");

            RuleFor(c => c.Image)
                .NotEmpty()
                .WithMessage("Imagem do produto não informado");

            RuleFor(x => x.Points)
                .GreaterThan(0)
                .WithMessage("Pontuação do produto deve ser maior que zero.");

        }
    }
}
