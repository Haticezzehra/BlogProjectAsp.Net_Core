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
            RuleFor(x=>x.BlogTitle).NotEmpty();
            RuleFor(x => x.BlogContent).NotEmpty();
            RuleFor(x => x.BlogImage).NotEmpty();
            RuleFor(x => x.BlogTitle).MaximumLength(150);
            RuleFor(x => x.BlogTitle).MinimumLength(150);


        }
    }
}
