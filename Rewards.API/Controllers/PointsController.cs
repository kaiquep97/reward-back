using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Interfaces;
using Rewards.Core.ViewModels;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PointsController : ControllerBase
    {
        private readonly IPointService _service;

        public PointsController(IPointService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PointViewModel model)
        {
            _service.UpdatePoints(model.UserId, model.Pontuation);

            return Ok();
        }
    }
}
