
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Flocker.BlobStorageService
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file, string filename)
        {

            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient("productimages");

            //BlobClient blobClient = containerClient.GetBlobClient(filename);


           await containerClient.UploadBlobAsync(filename, file.OpenReadStream());

            return containerClient.Uri.AbsoluteUri+$"/{filename}";

            //using (var stream = System.IO.File.Create(filePath))
            //{
            //    await containerClient.UploadBlobAsync(filename, stream);

            //}



        }
    }
}
