using Elmah.Io.AspNetCore;
using Elmah.Io.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.Configurations.Extensions
{
    public static class LoggerConfiguration
    {

        public static IServiceCollection AddLoggerConfiguration(this IServiceCollection services)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "3f005f20b0fc4bebac5924698b13ce44";
                o.LogId = new Guid("3d92b498-fc4e-4230-8b73-04d041e29cb2");
            });

            services.AddLogging(builder =>
            {
                builder.Services.AddElmahIo(o =>
               {
                   o.ApiKey = "3f005f20b0fc4bebac5924698b13ce44";
                   o.LogId = new Guid("3d92b498-fc4e-4230-8b73-04d041e29cb2");
               });
                builder.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Information);
            });

            return services;
        }

        public static IApplicationBuilder UseLoggerConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();
            return app;
        }

    }
}
