using Blog.Data.Context;
using Blog.Data.Repositories.Abstraction;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Blog.Service.Service.Abstractions;
using Blog.Service.Service.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services, IConfiguration confing)
        {
            var assembly = Assembly.GetExecutingAssembly();


           services.AddScoped<lArticleService, ArticleService>();

            services.AddAutoMapper(assembly);

            return services;

        }
    }
}
