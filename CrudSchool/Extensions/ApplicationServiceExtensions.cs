using Core.Interfaces;
using Infrastructure.UnitOfWork;

namespace CrudSchool.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) => 
            services.AddCors(
            option =>
            {
                option.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            }
            );

        public static void AddApplicationServices(this IServiceCollection services) => 
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        
    }
}
