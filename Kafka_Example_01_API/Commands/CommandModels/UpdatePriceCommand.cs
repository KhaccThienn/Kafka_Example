namespace Kafka_Example_01_API.Commands.CommandModels
{
    public record UpdatePriceCommand(Guid ProductId, decimal Price) : ICommand;
}
