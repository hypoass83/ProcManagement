
using Application.Interface.Security;
using Infrastructure.Services.Security;
using Microsoft.Extensions.DependencyInjection;


namespace Insfrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureStores(this IServiceCollection services)
        {


            // Security

            services.AddSingleton<IEncryptionService>(new EncryptionService());


            services.AddHttpContextAccessor();
            return services;
        }
    }
}

