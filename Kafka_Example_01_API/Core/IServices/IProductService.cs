namespace Kafka_Example_01_API.Core.IServices
{
    public interface IProductService
    {
        List<TableProduct> GetProducts();

        TableProduct InsertProduct(TableProduct p);

        TableProduct UpdatePrice(string key, Guid productId, decimal price);

        TableProduct UpdateQuantity(string key, Guid productId, decimal quantity, bool increase);
    }
}
