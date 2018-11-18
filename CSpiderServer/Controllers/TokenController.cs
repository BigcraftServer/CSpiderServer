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
    public class TokenController : ControllerBase
    {
        private TokenService _TokenService { get; set; }
        public TokenController(TokenService tokenService)
        {
            this._TokenService = tokenService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Models.RequestModels.User user)
        {
            return Ok(_TokenService.Create(user));
        }
    }
}