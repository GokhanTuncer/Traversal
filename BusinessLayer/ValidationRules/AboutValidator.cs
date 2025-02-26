﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("About field cannot be empty...!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please select an Image...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Please write atleast 50 character in the about field...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Please shorten the about field...!");

        }

    }
}
