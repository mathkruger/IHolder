using IHolder.Business.Entities;
using IHolder.Business.Interfaces;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Interfaces.Repositories;
using IHolder.Business.Interfaces.Services;
using IHolder.Business.Notifications;
using IHolder.Business.Repositories.Base;
using IHolder.Business.Services;
using IHolder.Data.Context;
using IHolder.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.Configurations.Extensions
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IHolderContext>();
            services.AddScoped<INotifier, Notifier>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ISituacaoRepository, SituacaoRepository>();
            services.AddScoped<IAporteRepository, AporteRepository>();
            services.AddScoped<IAtivoRepository, AtivoRepository>();
            services.AddScoped<IAtivoService, AtivoService>();

            services.AddScoped<ITipo_investimentoRepository, Tipo_investimentoRepository>();
            services.AddScoped<ITipo_investimentoService, Tipo_investimentoService>();

            services.AddScoped<IRepositoryBase<Usuario>, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IUser, AspNetUser>();

            return services;
        }
    }
}
