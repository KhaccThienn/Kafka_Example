namespace Kafka_Example_01_API.Commands.CommandModels
{
    public record UpdateQuantityCommand(Guid ProductId, decimal Quantity, bool Increase) : ICommand;
}
