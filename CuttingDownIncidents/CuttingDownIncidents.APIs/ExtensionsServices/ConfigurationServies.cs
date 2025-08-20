using CuttingDownIncidents.Data;
using CuttingDownIncidents.Infrastructure.Mapping;
using CuttingDownIncidents.Service.Implementation.IServices;
using CuttingDownIncidents.Service.Implementation.Servies;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using System.IO.Compression;
using System.Text.Json;
using System.Threading.RateLimiting;

namespace CuttingDownIncidents.APIs.ExtensionsServices
{
    public static class ConfigurationServies
    {
        public static IServiceCollection AddConfigurationServices(this IServiceCollection services)
        {
            // Register your services here
          
            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });


            services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.SerializerOptions.WriteIndented = false;
            });


            services.AddRateLimiter(options =>
            {

                options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
                    RateLimitPartition.GetFixedWindowLimiter(
                        partitionKey: context.Request.Headers["X-Forwarded-For"].FirstOrDefault() ??
                                     context.Connection.RemoteIpAddress?.ToString() ?? "anonymous",
                        factory: partition => new FixedWindowRateLimiterOptions
                        {
                            AutoReplenishment = true,
                            PermitLimit = 10,
                            Window = TimeSpan.FromSeconds(1)
                        }));


                options.AddFixedWindowLimiter("BandwidthLimit", options =>
                {
                    options.PermitLimit = 100;
                    options.Window = TimeSpan.FromMinutes(1);
                    options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                    options.QueueLimit = 5;
                });

                options.OnRejected = async (context, token) =>
                {
                    context.HttpContext.Response.StatusCode = 429;
                    await context.HttpContext.Response.WriteAsync("Rate limit exceeded", token);
                };
            });


            services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:4200")
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials();
                });
            });

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(services.BuildServiceProvider().GetRequiredService<IConfiguration>()
                    .GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });
            services.AddAuthentication().AddCookie();

            services.AddHttpContextAccessor();

            services.AddSwaggerGen();
            return services;
        }
    }
}
