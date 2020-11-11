using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcore_n_tier.DTO.DTOs
{
    public class UserToUpdateDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
