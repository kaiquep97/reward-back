using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Interfaces;
using Rewards.Core.ViewModels;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public AuthController(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Authenticate([FromBody] LoginViewModel model)
        {
            var user = _userRepository.Get(model.Email, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário e/ou senha invalidos" });

            var token = _tokenService.GenerateToken(user);

            user.Password = "";

            return Ok(new
            {
                user = user,
                token = token
            });
        }
    }
}
