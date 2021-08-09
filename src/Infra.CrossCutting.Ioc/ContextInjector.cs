using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.Ioc
{
    public static class ContextInjector
    {
        public static IServiceCollection AddDatabaseContextForApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NewsContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultDatabase"))
            );
            return services;
        }
    }
}
