using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Rewards.Core.Configuration;
using Rewards.Core.Interfaces;

namespace Rewards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ImageController : ControllerBase
    {
        private readonly AzureStorageConfig storageConfig;
        private readonly IImageService _imageService;

        public ImageController(IOptions<AzureStorageConfig> config, IImageService imageService)
        {
            storageConfig = config.Value;
            _imageService = imageService;
        }

        [HttpPost]
        [Route("Upload")]
        public IActionResult Post([FromForm] IFormFile file)
        {
            var url = _imageService.UploadImage(file, storageConfig);

            return Ok(url);
        }
    }
}
