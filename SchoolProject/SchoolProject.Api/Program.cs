
using Microsoft.EntityFrameworkCore;
using SchoolCore;
using SchoolCore.MiddleWare;
using SchoolInfrastructure;
using SchoolInfrastructure.Abstract;
using SchoolInfrastructure.Data;
using SchoolInfrastructure.repository;
using SchoolService;

namespace SchoolProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddSwaggerGen();
            builder.Services.AddEndpointsApiExplorer();



            builder.Services.AddDbContext<ApplicationDBContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            builder.Services.AddModuleCoreDependancy();       
            builder.Services.AddModuleInfrastructureDependancy(); 
            builder.Services.AddModuleServiceDependancy();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}
