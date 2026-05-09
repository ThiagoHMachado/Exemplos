using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitectureCQRS.Application.Commands.Validator
{
    public class ClienteValidator : AbstractValidator<CriarClienteCommand>
    {

        public ClienteValidator()
        {
            RuleFor(x => x.entity.Nome)
           .NotEmpty();
            //RuleFor(x => x.entity.DataNascimento).Must(ValidadeDate);
        }
        private bool ValidadeDate(DateOnly? date)
        {
            if (date.HasValue)
                return date.Value.ToString().BeAValidDate();
            else
                return true;
        }
    }
}
