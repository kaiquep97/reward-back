using Rewards.Core.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface IImageRepository
    {
        string UploadFile(Stream fileStream, string fileName, AzureStorageConfig config);
    }
}
