using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.Configurations.Extensions
{
    public static class ApiConfiguration
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddCors(options =>
            {
                options.AddPolicy("Development",
                    builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());

                options.AddPolicy("Production",
                    builder =>
                    builder.WithMethods("GET", "POST", "PUT")
                    .WithOrigins("https://mydomain.com/")
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
                    .AllowAnyHeader());
            });


            return services;
        }
    }
}
