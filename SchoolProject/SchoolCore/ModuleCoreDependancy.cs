using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolCore.Basics;
using SchoolCore.Behavior;
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

            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


            services.AddScoped<ResponseHandler>();
            return services;
        }
    }
}
