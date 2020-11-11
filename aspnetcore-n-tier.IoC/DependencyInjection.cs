using System;
using System.Collections.Generic;
using System.Text;
using aspnetcore_n_tier.BLL.Services;
using aspnetcore_n_tier.BLL.Services.IServices;
using aspnetcore_n_tier.DAL.DataContext;
using aspnetcore_n_tier.DAL.Repositories;
using aspnetcore_n_tier.DAL.Repositories.IRepositories;
using aspnetcore_n_tier.Utility.Utilities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetcore_n_tier.IoC
{
    public class DependencyInjection
    {
        private readonly IConfiguration Configuration;
        public DependencyInjection(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void InjectDependencies(IServiceCollection services)
        {
            services.AddDbContext<AspNetCoreNTierDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("netcorewebapintiertemplatedb"));
            });

            services.AddAutoMapper(typeof(AutoMapperProfiles));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
