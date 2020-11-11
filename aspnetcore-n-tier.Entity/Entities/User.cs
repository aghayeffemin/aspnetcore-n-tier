using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcore_n_tier.Entity.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
