namespace Kafka_Example_01_API.Core.DTOs
{
    public class UpdatePriceDTO
    {
        public Guid    ProductId { get; set; }
        public decimal Price     { get; set; }
    }
}
