using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Entities;
using Rewards.Core.Interfaces;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;

        public UserController(IUserRepository userRepository, IUserService userService)
        {
            _userRepository = userRepository;
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.List();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userRepository.GetWithPontuation(id);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User value)
        {
            var usu = _userRepository.Get(id);

            if (usu == null)
                return NotFound(new { message = "Usuário não encontrado" });

            _userService.Update(value, usu);

            return Ok();

        }

    }
}
