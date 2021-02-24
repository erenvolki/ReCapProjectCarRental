using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b=> b.Name).MinimumLength(3).WithMessage("Marka adı uzunluğu 3 karakterden az olamaz");
        }
    }
}
