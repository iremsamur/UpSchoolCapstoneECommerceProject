using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolCapstoneProject.BusinessLayer.DIContainer
{
    public static class Extensions
    {
        public static void Containerdependencies(this IServiceCollection services)
        {
            //Startup içindeki tüm servisleri IServiceCollection'ları burada almak için IServiceCollection'ı veriyoruz.
            //Startup'daki servisler çok fazla olduğu için, business ya da data access layer içinde containerdependencies içinde ServiceCollection burada çağırılır. 
            //Buradaki this ise Bu IServiceCollection'ı kullandığımızı belirtiyor.
            //services.AddScoped<ICategoryService, CategoryManager>();
            //services.AddScoped<IItemDal, EfCategoryDal>();
           

        }
        //Automapper için 
        public static void CustomizeValidator(this IServiceCollection services)
        {
            //DTO ve onun ilgili validator eşleştirmelerini burada yazıp tanımlıyoruz
            //services.AddTransient<IValidator<ContactAddDTO>, ContactAddValidator>();
            //services.AddTransient<IValidator<ContactUpdateDTO>, ContactUpdateValidator>();



        }
    }
}
