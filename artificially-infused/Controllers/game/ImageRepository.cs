using Azure.Storage.Blobs;

namespace artificially_infused.Controllers.game
{
    public class ImageRepository
    {
        private BlobContainerClient _blobContainerClient;

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
                return $"https://startificiallyinfuseddev.blob.core.windows.net/aiimages/{gameId}/{roundNumber}/{playerId}.png";
            }
        }
    }
}
