﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Whiskey.Data.DatabaseContext;
using Whiskey.Data.Repositories.Input;
using Whiskey.Data.Repositories.Output;
using Whiskey.Domain.Repository.Input;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.IoC.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories();

            services.AddDbContextPool<ApplicationDbContext>(opts => opts
                    .UseMySql(configuration.GetConnectionString("DbConnection"),
                     ServerVersion.AutoDetect(configuration.GetConnectionString("DbConnection")),
                     b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            return services;
        }
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICategoryWriteRepository), typeof(CategoryWriteRepository));
            services.AddScoped(typeof(ICostumerWriteRepository), typeof(CostumerWriteRepository));
            services.AddScoped(typeof(IOrderWriteRepository), typeof(OrderWriteRepository));
            services.AddScoped(typeof(ICategoryReadRepository), typeof(CategoryReadRepository));
            services.AddScoped(typeof(ICostumerReadRepository), typeof(CostumerReadRepository));
            services.AddScoped(typeof(IOrderItemReadRepository), typeof(OrderItemReadRepository));
            services.AddScoped(typeof(IOrderReadRepository), typeof(OrderReadRepository));
            services.AddScoped(typeof(IProductReadRepository), typeof(ProductReadRepository));





            return services;
        }
    }
}
