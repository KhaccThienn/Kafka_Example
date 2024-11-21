namespace Kafka_Example_01_API.Commands.CommandModels
{
    public record InsertProductCommand(Guid Id, string Name, decimal Price, decimal Quantity) : ICommand;
}
