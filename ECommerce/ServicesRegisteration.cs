using ECommerce.Business;
using ECommerce.Core.Entities;
using ECommerce.Repository;
using ECommerce.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ECommerce.API
{
    public static class ServicesRegisteration
    {
        public static IServiceCollection AddUnitOfWorkServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
        public static IServiceCollection AddMyDbContext(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<TestECommerceContext>();
            return services;
        }
        public static IServiceCollection AddCorsServices(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            return services;
        }

        public static IServiceCollection AddBLLServices(this IServiceCollection services)
        {
            foreach (var implementationType in typeof(BaseBLL).Assembly.GetTypes().Where(s => s.IsClass && s.Name.EndsWith("BLL") && !s.IsAbstract))
            {
                foreach (var interfaceType in implementationType.GetInterfaces())
                {
                    services.AddScoped(interfaceType, implementationType);
                }
            }
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            var repositoryTypes = typeof(BaseRepository<>).Assembly.GetTypes()
            .Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(BaseRepository<>));

            foreach (var repositoryType in repositoryTypes)
            {
                var genericArguments = repositoryType.BaseType.GetGenericArguments();
                var interfaceType = typeof(IRepository<>).MakeGenericType(genericArguments);
                services.AddScoped(repositoryType);
            }
            return services;
        }
    }
}
