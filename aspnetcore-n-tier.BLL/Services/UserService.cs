using aspnetcore_n_tier.BLL.Services.IServices;
using aspnetcore_n_tier.DAL.Repositories.IRepositories;
using aspnetcore_n_tier.DTO.DTOs;
using aspnetcore_n_tier.Entity.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aspnetcore_n_tier.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserToListDTO> AddUser(UserToAddDTO userToAddDTO)
        {
            return _mapper.Map<UserToListDTO>(await _userRepository.Add(_mapper.Map<User>(userToAddDTO)));
        }

        public async Task<List<UserToListDTO>> GetUsers()
        {
            return _mapper.Map<List<UserToListDTO>>(await _userRepository.GetList());
        }
    }
}
