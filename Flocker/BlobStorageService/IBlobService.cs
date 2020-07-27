using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.BlobStorageService
{
    public interface IBlobService
    {

        public Task<string> UploadFileBlobAsync(IFormFile file, string filename);




    }
}
