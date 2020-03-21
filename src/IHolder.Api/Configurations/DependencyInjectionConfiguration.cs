using IHolder.Business.Interfaces;
using IHolder.Data.Context;
using IHolder.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IHolderContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ISituacaoRepository, SituacaoRepository>();
            return services;
        }
    }
}
