using Application.Core;
using Application.RigOperators;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddCors(option =>
            {
                option
                    .AddPolicy("CorsPolicy", policy =>
                    {
                        policy
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .WithOrigins("http://localhost:3000");
                    });
            });
            services.AddMediatR(typeof(ListRigOperator.Handler).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            return services;
        }
    }
}