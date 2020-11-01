using Microsoft.AspNetCore.Http;
using Rewards.Core.Configuration;
using Rewards.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Service
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public string UploadImage(IFormFile file, AzureStorageConfig azureStorageConfig)
        {
            if (!isImage(file))
                throw new Exception("Imagem não é valida");

            using (var stream = file.OpenReadStream())
            {
                return _imageRepository.UploadFile(stream, file.FileName, azureStorageConfig);
            }
        }

        private bool isImage(IFormFile file)
        {
            return true;
        }
    }
}
