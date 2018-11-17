using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSpiderServer.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSpiderServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService userService;
        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        
        [HttpPost]
        public IActionResult Create(Models.RequestModels.User user) {
            return Ok(userService.Save(user));
        }
    }
}