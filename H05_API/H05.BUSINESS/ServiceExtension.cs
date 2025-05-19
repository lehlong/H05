using Microsoft.Extensions.DependencyInjection;
using H05.CORE;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.EntityFrameworkCore;
using H05.BUSINESS.Common;
using H05.BUSINESS.Services;

namespace H05.BUSINESS
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(cfg => { cfg.AddExpressionMapping(); }, typeof(MappingProfile).Assembly);
           
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("Connection")));
            
            var allProviderTypes = Assembly.GetAssembly(typeof(IAccountTypeService))
             .GetTypes().Where(t => t.Namespace != null).ToList();
            foreach (var intfc in allProviderTypes.Where(t => t.IsInterface))
            {
                var impl = allProviderTypes.FirstOrDefault(c => c.IsClass && !c.IsAbstract && intfc.Name[1..] == c.Name);
                if (impl != null) services.AddScoped(intfc, impl);
            }

            return services;
        }
    }
}
