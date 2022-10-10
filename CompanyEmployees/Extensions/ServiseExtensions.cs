using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Contracts.Class1;

namespace CompanyEmployees.Extensions
{
    public static class ServiseExtensions
    {
        public static void ConfigureCors(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) =>
 services.AddCors(options =>
 {
     options.AddPolicy("CorsPolicy", builder =>
     builder.AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
 });


        public static void ConfigureIISIntegration(this IServiceCollection services) =>
 services.Configure<Microsoft.AspNetCore.Builder.IISOptions>(options =>
 {

 });
        public static void ConfigureLoggerService(this IServiceCollection services) =>
 services.AddScoped<ILoggerManager, ILoggerManager>();
    }
}
