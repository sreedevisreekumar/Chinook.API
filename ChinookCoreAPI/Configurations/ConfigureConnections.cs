using Chinook.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.API.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("ChinookDb") ?? "Server=.;Database=Chinook;Trusted_Connection=True;";
            services.AddDbContext<ChinookContext>(options => options.UseSqlServer(connection));
            return services;
        }
    }
}
