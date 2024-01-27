using Azure;
using Azure.Data.Tables;

namespace artificially_infused.Controllers.tv
{
    public class BaseEntity: ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }


    }
}
