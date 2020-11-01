using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using Rewards.Core.ViewModels;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IUserService userService, IMapper mapper, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _userService = userService;
            _tokenService = tokenService;

            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.List();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userRepository.GetWithPontuation(id);

            var viewModel = _mapper.Map<UserViewModel>(user);

            return Ok(viewModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserViewModel value)
        {
            var usu = _userRepository.Get(id);

            if (usu == null)
                return NotFound(new { message = "Usuário não encontrado" });

            var user = _mapper.Map<User>(value);

            _userService.Update(user, usu);

            return Ok();

        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] CreateUserViewModel value)
        {
            var user = _mapper.Map<User>(value);

            _userRepository.Insert(user);

            var token =_tokenService.GenerateToken(user);

            return Ok(new { token });
        }


    }
}
