using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace artificially_infused.Controllers.game
{
    public class ImageRepository
    {
        private BlobContainerClient _blobContainerClient;
        private const string BLOB_ROOT_URL = "https://startificiallyinfuseddev.blob.core.windows.net/aiimages";
        public ImageRepository(string blobConnectionString)
        {
            //var connectionStringVariableName = "CUSTOMCONNSTR_startificiallyinfuseddev";
            //var connectionString = Environment.GetEnvironmentVariable(connectionStringVariableName);
            //if (connectionString == null)
            //{
            //    throw new ArgumentException("Unable to find the blob storage connection string");
            //}

            _blobContainerClient = new BlobContainerClient(blobConnectionString, "aiimages");
        }

        public async Task<string> Upload(byte[] data, string gameId, int roundNumber, string playerId)
        {
            // Upload the byte array to the blob
            using (var stream = new MemoryStream(data, false))
            {
                var blobResponse = await _blobContainerClient.UploadBlobAsync($"{gameId}/{roundNumber}/{playerId}.png", stream);
                return $"{BLOB_ROOT_URL}/{gameId}/{roundNumber}/{playerId}.png";
            }
        }
        public async Task<List<string>> GetBlobsAsync()
        {
            List<string> blobs = new List<string>();
            await foreach (var blobItem in _blobContainerClient.GetBlobsAsync())
            {
                blobs.Add($"{BLOB_ROOT_URL}/{blobItem.Name}");
            }
            return blobs;
        }
    }
}
