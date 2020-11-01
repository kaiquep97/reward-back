using Azure.Storage;
using Azure.Storage.Blobs;
using Rewards.Core.Configuration;
using Rewards.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Rewards.Infra
{
    public class ImageRepository : IImageRepository
    {
        public string UploadFile(Stream fileStream, string fileName, AzureStorageConfig config)
        {
            var blobUri = new Uri($"https://{config.AccountName}.blob.core.windows.net/{config.ImageContainer}/{fileName}");

            StorageSharedKeyCredential storageCredentials = new StorageSharedKeyCredential(config.AccountName, config.AccountKey);

            BlobClient blobClient = new BlobClient(blobUri, storageCredentials);

            var response = blobClient.Upload(fileStream);

            return blobUri.ToString();
        }
    }
}
