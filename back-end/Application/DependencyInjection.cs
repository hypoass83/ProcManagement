

using Application.Services.Secutity;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Security


            services.AddScoped<AuthService>();

            return services;
        }
    }
}

