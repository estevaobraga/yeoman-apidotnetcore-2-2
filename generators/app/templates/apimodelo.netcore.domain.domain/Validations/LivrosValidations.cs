using <%= nomeProj %>.domain.domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace <%= nomeProj %>.domain.domain.Validations
{
    public class LivrosValidations : AbstractValidator<Livros>
    {
        public LivrosValidations()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithName("Preencha o nome do livro");
        }
    }
}
