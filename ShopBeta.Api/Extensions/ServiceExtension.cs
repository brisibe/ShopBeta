using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopBeta.Core.Interfaces;
using ShopBeta.Infrastructure.Logging;
using ShopBeta.Infrastructure.Repository;
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


        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
    services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
        b => b.MigrationsAssembly("ShopBeta.Api"))); //migrations  not in our base entities project so we just change the project for the migration assembly;
                                                      //Add-Migration {name} - to create migragion
                                                      //Update-DAtabase - creates the databaseds


        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
