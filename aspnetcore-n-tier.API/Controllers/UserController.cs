using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_n_tier.BLL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_n_tier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("getusers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                return Ok(await _userService.GetUsers());
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}