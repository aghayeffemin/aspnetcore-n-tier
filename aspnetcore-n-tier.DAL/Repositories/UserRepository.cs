using aspnetcore_n_tier.DAL.DataContext;
using aspnetcore_n_tier.DAL.Repositories.IRepositories;
using aspnetcore_n_tier.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcore_n_tier.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AspNetCoreNTierDbContext _aspNetCoreNTierDbContext;
        public UserRepository(AspNetCoreNTierDbContext aspNetCoreNTierDbContext) : base(aspNetCoreNTierDbContext)
        {
            _aspNetCoreNTierDbContext = aspNetCoreNTierDbContext;
        }
    }
}
