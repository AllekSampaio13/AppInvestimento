using AppInvest.Application.Mapper;
using AppInvest.Application.Services;
using AppInvest.Application.Services.Interfaces;
using AppInvest.Domain.Interfaces.Repositories;
using AppInvest.Domain.Interfaces.Services;
using AppInvest.Domain.Services;
using AppInvest.Infra.Data.Repositories;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

    namespace AppInvest.Infra.IoC
    {
        public static class AcoesModule
        {
            private static void ConfigureMapper(this IServiceCollection services)
            {
                var mapperConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new DomainToViewModelProfile());
                });

                services.AddSingleton(mapperConfig.CreateMapper());
            }
            public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
            {
                services.ConfigureMapper();

                return services;
            }

            public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
            {
                services.AddScoped<IAcoesAppService, AcoesAppService>();
                services.AddScoped<IAcoesService, AcoesService>();
                services.AddScoped<IAcoesRepository, AcoesRepository>();

                return services;
            }
        }
    }