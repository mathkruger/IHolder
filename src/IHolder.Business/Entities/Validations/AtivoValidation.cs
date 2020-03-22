using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities.Validations
{
    public class AtivoValidation : AbstractValidator<Ativo>
    {
        public AtivoValidation()
        {
            RuleFor(f => f.Cotacao)
                .GreaterThan(1).WithMessage("O valor da cotação precisa ser maior do que {valueToCompare}");
        }
    }
}
