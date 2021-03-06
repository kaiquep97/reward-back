﻿using FluentValidation;
using Rewards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Validators
{
    public class CreateUserViewModelValidator: AbstractValidator<CreateUserViewModel>
    {
        public CreateUserViewModelValidator()
        {
            RuleFor(c => c.Cpf)
                .NotEmpty()
                .WithMessage("CPF não informado");

            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Nome não informado");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email não informado");
        }
    }
}
