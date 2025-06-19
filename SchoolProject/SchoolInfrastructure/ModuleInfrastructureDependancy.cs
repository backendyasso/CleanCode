using Microsoft.Extensions.DependencyInjection;
using SchoolInfrastructure.Abstract;
using SchoolInfrastructure.InfrastructureBasics;
using SchoolInfrastructure.repository;

namespace SchoolInfrastructure
{
    public static class ModuleInfrastructureDependancy
    {
        public static IServiceCollection AddModuleInfrastructureDependancy(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepo, StudentRepo>();

            services.AddTransient<IDepartmentRepo, DepartmentRepo>();
            services.AddScoped<ISubjectRepo, SubjectRepo>();


            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}
