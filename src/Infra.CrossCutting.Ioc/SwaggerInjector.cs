using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Infra.CrossCutting.Ioc
{
    public static class SwaggerInjector
    {
        public static IServiceCollection AddSwaggerCustomConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = $"{configuration["Application:Name"]} - Environment: {configuration["Application:Environment"]}",
                    Version = "v1",
                    Description = configuration["Application:Description"]
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Favor informar token com bearer no começo separado por espaço",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });


                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                c.IgnoreObsoleteActions();
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerCustomConfig(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.EnableValidator();
                c.SwaggerEndpoint("/api/swagger/v1/swagger.json", $"{configuration["Application:Name"]}");
                c.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}
