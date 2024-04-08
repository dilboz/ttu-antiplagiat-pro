using api.Validation;
using contracts.LogService;
using contracts.User;
using entities.DataContexts;
using log;
using Microsoft.EntityFrameworkCore;
using repositories;
using services;

namespace api.Extensions
{
    public static class ServiceRegistrations
    {
        public static void ConfigureDataContext(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseNpgsql(Environment.GetEnvironmentVariable("DB_CONNECTION") ?? string.Empty,
                        npgsqlOptions => npgsqlOptions.MigrationsAssembly("api"))
                    .LogTo(Console.WriteLine));
        }

        public static void ConfigureDIs(this IServiceCollection service)
        {
            service.AddScoped<ILoggerManager, LoggerManager>();
            
            service.AddScoped<IUserValidation, UserValidation>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IUserRepository, UserRepository>();
        }
    }
}