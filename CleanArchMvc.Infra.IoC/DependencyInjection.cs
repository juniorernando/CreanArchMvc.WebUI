using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Mappings;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchMvc.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ICategoryRepository, ICategoryRepository>();
            services.AddScoped<IProductRepository, IProductRepository>();
            services.AddScoped<IProductService, IProductService>();
            services.AddScoped<ICategoryService, ICategoryService>();
            services.AddAutoMapper(typeof(DomainDTOMappingProfile));

            var myDependency = AppDomain.CurrentDomain.Load("CleanArchMvc.Application");
            services.AddMediatR(myDependency);

            return services;
        }

    }
}
