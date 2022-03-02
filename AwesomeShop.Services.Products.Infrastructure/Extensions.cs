using AwesomeShop.Services.Products.Core.Repositories;
using AwesomeShop.Services.Products.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeShop.Services.Products.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
