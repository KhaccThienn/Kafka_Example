using Kafka_Example_01_API.Core.Models;

namespace Kafka_Example_01_API.Core.IServices
{
    public interface IProductPersistenceService
    {
        Task<TableProduct> InsertProduct(TableProduct p);
        Task<TableProduct> UpdateQuantity(Guid productId, decimal quantity, bool Increase);
        Task<TableProduct> UpdatePrice(Guid productId, decimal price);
    }
}
