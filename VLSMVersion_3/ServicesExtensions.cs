using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace VLSMVersion_3
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqliteContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<VlsmDb>(options =>
                options.UseSqlite(configuration.GetConnectionString("sqliteConnection"), m => m.MigrationsAssembly("DatabaseContext")));

        public static void ConfigureRepositoryManager(this IServiceCollection service) =>
            service.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
