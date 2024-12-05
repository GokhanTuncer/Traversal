﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
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



        }
	}
}
