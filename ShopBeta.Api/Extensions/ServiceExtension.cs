using Microsoft.Extensions.DependencyInjection;
using ShopBeta.Core.Interfaces;
using ShopBeta.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBeta.Api.Extensions
{
    public static class ServiceExtension
    {

        public static void ConfigureCors(this IServiceCollection services) =>
                services.AddCors(options =>
                {
                    options.AddPolicy("CorsPolicy", builder =>
                        builder.WithOrigins("https://localhost:3000")
                        .AllowAnyMethod()
                        .AllowAnyHeader());

                });


        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();
    }
}
