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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetByCategoryId")]
        [AllowAnonymous]
        public IActionResult GetProducts([FromQuery]int category_id, int? pageIndex, int? pageSize)
        {
            var products = _productService.GetProductsByCategory(category_id, pageSize, pageIndex);

            return Ok(products);
        }

        [HttpGet]
        [Route("GetPaginated")]
        [AllowAnonymous]
        public IActionResult GetProducts(int? pageIndex, int? pageSize)
        {
            var products = _productService.GetProductsPaginated(pageSize, pageIndex);

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.Get(id);

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductViewModel data)
        {
            var product = _mapper.Map<Product>(data);


            _productService.Insert(product);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] UpdateProductViewModel data)
        {
            var product = _productService.Get(id);

            if (product == null)
                return NotFound(new { message = "Produto não encontrado" });

            var newProduct = _mapper.Map<Product>(data);

            _productService.Update(newProduct, product);

            return Ok();
        }
    }
}
