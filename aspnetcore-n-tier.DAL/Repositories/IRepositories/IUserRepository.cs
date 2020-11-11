using aspnetcore_n_tier.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcore_n_tier.DAL.Repositories.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
