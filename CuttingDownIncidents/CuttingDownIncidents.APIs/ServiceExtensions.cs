using CuttingDownIncidents.Data;
using CuttingDownIncidents.Infrastructure.Mapping;
using CuttingDownIncidents.Service.Implementation.IServices;
using CuttingDownIncidents.Service.Implementation.Servies;
using Microsoft.Extensions.DependencyInjection;
using CuttingDownIncidents.Infrastructure.Mapping;
namespace CuttingDownIncidents.APIs
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register your services here
            services.AddScoped<IGetDataService, GetDataService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            

            services.AddAutoMapper(config =>
            {
                // Add your profiles here
                config.AddProfile<ProblemTypesMappingProfile>();
            });
            return services;
        }
    }
}
