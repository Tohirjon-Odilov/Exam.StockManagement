using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Infrastructure.BaseRepositories;
using Exam.StockManagement.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.StockManagement.Infrastructure

{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration conf)
        {
            services.AddDbContext<StockManagementDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseNpgsql(conf.GetConnectionString("StockManagementConnectionString"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStatsRepository, StatsRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
