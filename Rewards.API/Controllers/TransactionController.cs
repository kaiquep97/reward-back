using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Entities;
using Rewards.Core.ViewModels;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMapper _mapper;

        public TransactionController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult Post([FromBody] TransactionViewModel data)
        {
            var transaction = _mapper.Map<Transaction>(data);

            return Ok();
        }
    }
}
