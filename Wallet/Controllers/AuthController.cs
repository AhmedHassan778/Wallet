using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authServic;

        public AuthController(IAuthService authServic)
        {
            _authServic = authServic;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var result = await _authServic.RegisterAsync(model);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(new
            {
                token = result.Token,
                ExpiresOn = result.ExpiresOn,
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _authServic.LoginAsync(model);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(new
            {
                token = result.Token,
                ExpiresOn = result.ExpiresOn,
            });
        }



    }
}
