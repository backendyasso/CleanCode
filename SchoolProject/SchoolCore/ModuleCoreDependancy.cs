using Microsoft.Extensions.DependencyInjection;
using SchoolInfrastructure.Abstract;
using SchoolInfrastructure.repository;
using System.Reflection;

namespace SchoolCore
{
    public static class ModuleCoreDependancy
    {
        public static IServiceCollection AddModuleCoreDependancy(this IServiceCollection services)
        {
            services.AddMediatR(c => c.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            
            
            return services;
        }
    }
}
