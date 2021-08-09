using Domain.Aggregates.NewsAgreggate;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Facades;
using Presentation.Interfaces;

namespace Infra.CrossCutting.Ioc
{
    public static class ServicesInjector
    {
        public static IServiceCollection AddServicesForApplication(this IServiceCollection services)
        {
            services.AddTransient<INewsFacade, NewsFacade>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<INewsRepository, NewsRepository>();
            return services;
        }

    }
}
