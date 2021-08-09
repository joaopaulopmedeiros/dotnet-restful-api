using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Presentation.Facades;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.CrossCutting.Ioc
{
    public static class ServicesInjector
    {
        public static IServiceCollection AddServicesForApplication(this IServiceCollection services)
        {
            services.AddTransient<INewsFacade, NewsFacade>();   
            return services;
        }

    }
}
