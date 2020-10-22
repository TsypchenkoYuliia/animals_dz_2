using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.ModelDTO;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
     
        [HttpGet]
        public async Task<IEnumerable<UserDTO>> Get()
        {
            return await _userService.GetAsync();
        }

        [HttpPut]
        public async Task Put([FromBody] UserDTO model)
        {
            await _userService.UpdateAsync(model.Id, model.Role);
        }
    }
}
