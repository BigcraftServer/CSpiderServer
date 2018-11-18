using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CSpiderServer.BLL.ResponseMessages;
using CSpiderServer.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSpiderServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _UserService { get; set; }
        public UserController(UserService userService)
        {
            this._UserService = userService;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(IResponseMessage<Models.ResponseModels.User>))]
        public IActionResult Create(Models.RequestModels.User user)
        {
            return Ok(_UserService.Save(user));
        }
    }
}