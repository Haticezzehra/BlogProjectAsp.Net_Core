using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer name and surname are can't null");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adress is can't null.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password is cannot null");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("You can enter least two caracter.");

        }
    }
}
