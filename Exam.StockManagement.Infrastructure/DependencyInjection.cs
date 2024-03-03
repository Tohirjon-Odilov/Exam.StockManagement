using Exam.StockManagement.Application.Abstractions;
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
                options.UseNpgsql(conf.GetConnectionString("StockManagementConnectionString"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            return services;
        }
    }
}
