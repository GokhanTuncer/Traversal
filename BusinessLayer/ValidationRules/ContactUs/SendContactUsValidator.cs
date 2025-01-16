using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
	public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
	{
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanı 5 karakterden az olamaz");
            RuleFor(x => x.Subject).MinimumLength(100).WithMessage("Konu alanı 100 karakterden fazla olamaz");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail alanı 5 karakterden fazla olamaz");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Mail alanı 100 karakterden fazla olamaz");

        }
    }
}
