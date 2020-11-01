using Microsoft.AspNetCore.Http;
using Rewards.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface IImageService
    {
        string UploadImage(IFormFile file, AzureStorageConfig azureStorageConfig);
        
    }
}
