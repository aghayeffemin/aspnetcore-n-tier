using aspnetcore_n_tier.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aspnetcore_n_tier.BLL.Services.IServices
{
    public interface IUserService
    {
        Task<List<UserToListDTO>> GetUsers();
        Task<UserToListDTO> AddUser(UserToAddDTO userToAddDTO);
    }
}
