using CuttingDownIncidents.Data;
using CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact;
using CuttingDownIncidents.Domain.Entities.FactTables.Network;
using CuttingDownIncidents.Infrastructure.Mapping;
using CuttingDownIncidents.Infrastructure.Mapping;
using CuttingDownIncidents.Service.Implementation.IServices;
using CuttingDownIncidents.Service.Implementation.Servies;
using Microsoft.Extensions.DependencyInjection;
namespace CuttingDownIncidents.APIs.ExtensionsServices
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register your services here
            services.AddScoped<IGetDataService, GetDataService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRepository<CuttingDownHeader>, Repository<CuttingDownHeader>>();
            services.AddScoped<IRepository<CuttingDownDetail>, Repository<CuttingDownDetail>>();
            services.AddScoped<IRepository<NetworkElement>, Repository<NetworkElement>>();
            services.AddScoped<ICuttingDownService, CuttingDownService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            

            services.AddAutoMapper(config =>
            {
                // Add your profiles here
                config.AddProfile<ProblemTypesMappingProfile>();
   
                config.AddProfile<CuttingDownIgnoredMappingProfile>();
                config.AddProfile<NetworkElementHierarchyPathMappingProfile>();
                config.AddProfile<ChannelMappingProfile>();
                config.AddProfile<NetworkElementTypeMappingProfile>();
            });
            return services;
        }
    }
}
