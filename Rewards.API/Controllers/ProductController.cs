using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rewards.Core.Entities;
using Rewards.Core.Interfaces;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetByCategoryId")]
        public IActionResult GetProducts([FromQuery]int category_id, int? pageIndex, int? pageSize)
        {
            var products = _productService.GetProductsByCategory(category_id, pageSize, pageIndex);

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.Get(id);

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _productService.Insert(product);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Product data)
        {
            var product = _productService.Get(id);

            if (product == null)
                return NotFound(new { message = "Produto não encontrado" });

            _productService.Update(data, product);

            return Ok();
        }
    }
}
