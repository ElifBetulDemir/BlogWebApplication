﻿using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.ValidationRules;

public class WriterValidator : AbstractValidator<Writer>
{
    public WriterValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad kısmı boş geçilemez");
        RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
        RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
        RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın");
    }
}
