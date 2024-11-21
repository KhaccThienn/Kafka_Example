using Kafka_Example_01_API.Core.Models;

namespace Kafka_Example_01_API.Core.IRepositories
{
    public interface IProductRepository
    {
        List<TableProduct> GetProducts();

        TableProduct InsertProduct(TableProduct p);

        TableProduct UpdatePrice(Guid productId, decimal price);

        TableProduct UpdateQuantity(Guid productId, int quantity, bool increase);
    }
}
