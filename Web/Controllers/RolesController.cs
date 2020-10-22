using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        UserService _userService;
        public RolesController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Admin", "Employee", "Manager" };
        }
    }
}
