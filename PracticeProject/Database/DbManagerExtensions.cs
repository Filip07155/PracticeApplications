using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Database
{
    public static class DbManagerExtensions
    {
        public static IServiceCollection AddDatbaseContext(
            this IServiceCollection services, string path = "..")
        {
            string dbPath = Path.Combine(
                path, "Northwind.db");

            services.AddDbContext<DbManager>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            return services;
        }
    }
}
