using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Entities;
using Rewards.Core.Interfaces;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Category> Get()
        {
            return _categoryRepository.List();
        }

        public void Post([FromBody] Category category)
        {
            _categoryRepository.Insert(category);
        }
    }
}
