using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Application.Services;
using Exam.StockManagement.Application.Services.AuthServices;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.StockManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IStatsService, StatsService>();

            return services;
        }
    }
}

