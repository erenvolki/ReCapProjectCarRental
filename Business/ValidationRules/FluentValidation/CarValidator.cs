using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=> c.Name).MinimumLength(2).WithMessage("Araç adı uzunluğu 2 karakterden az olamaz");
            RuleFor(c=> c.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük kira bedeli 0'dan büyük olmalıdır.");
            RuleFor(c => c.Description).MinimumLength(10).WithMessage("Araç tanımı uzunluğu en az 10 karakter olmalıdır");
        }
    }
}
