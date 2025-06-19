using Microsoft.Extensions.DependencyInjection;
using SchoolInfrastructure.Abstract;
using SchoolInfrastructure.repository;
using SchoolService.Abstract;
using SchoolService.implementation;

namespace SchoolService
{
    public static class ModuleServiceDependancy
    {
        public static IServiceCollection AddModuleServiceDependancy(this IServiceCollection services)
        {
            services.AddScoped<IstudentService, StudentService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ISubjectService, SubjectService>();


            return services;
        }
    }
}
