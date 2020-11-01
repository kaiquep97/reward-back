using FluentValidation;
using Rewards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Validators
{
    public class TransactionValidator : AbstractValidator<TransactionViewModel>
    {
        public TransactionValidator()
        {
            RuleFor(c => c.UserId)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Usuario não informado");

            RuleForEach(c => c.Products)
                .GreaterThan(0)
                .WithMessage("Id dos produtos devem ser maior que zero");
        }
    }
}
