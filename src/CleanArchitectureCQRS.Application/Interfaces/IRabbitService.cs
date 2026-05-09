
namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IRabbitService
    {
        Task PublishAsync<T>(string routingKey, T message);
    }
}