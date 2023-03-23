using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {

        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty();
            RuleFor(x => x.BlogContent).NotEmpty();
            RuleFor(x => x.BlogImage).NotEmpty();
            RuleFor(x => x.BlogContent).MaximumLength(2000);
            RuleFor(x => x.BlogContent).MinimumLength(150);


        }
    }
}
