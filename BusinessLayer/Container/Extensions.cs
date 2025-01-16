using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUoW;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUoW;
using BusinessLayer.ValidationRules;
using BusinessLayer.ValidationRules.ContactUs;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection builder)
        {
            builder.AddScoped<ICommentService, CommentManager>();
            builder.AddScoped<ICommentDal, EfCommentDal>();

            builder.AddScoped<IDestinationService, DestinationManager>();
            builder.AddScoped<IDestinationDal, EfDestinationDal>();

            builder.AddScoped<IAppUserService, AppUserManager>();
            builder.AddScoped<IAppUserDal, EfAppUserDal>();

            builder.AddScoped<IReservationService, ReservationManager>();
            builder.AddScoped<IReservationDal, EfReservationDal>();

            builder.AddScoped<IGuideService, GuideManager>();
            builder.AddScoped<IGuideDal, EfGuideDal>();

            builder.AddScoped<IExcelService, ExcelManager>();
			builder.AddScoped<IPdfService, PdfManager>();

            builder.AddScoped<IContactUsService, ContactUsManager>();
			builder.AddScoped<IContactUsDal, EfContactUsDal>();

            builder.AddScoped<IAnnouncementService, AnnouncementManager>();
            builder.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            builder.AddScoped<IAccountService, AccountManager>();
            builder.AddScoped<IAccountDal, EfAccountDal>();

            builder.AddScoped<IUoWDal, UoWDal>();

        }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
			services.AddTransient<IValidator<SendMessageDTO>, SendContactUsValidator>();


		}
	}
}
