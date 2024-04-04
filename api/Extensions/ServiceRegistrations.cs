using contracts.LogService;
using entities.DataContexts;
using log;
using Microsoft.EntityFrameworkCore;

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
        }
    }
}