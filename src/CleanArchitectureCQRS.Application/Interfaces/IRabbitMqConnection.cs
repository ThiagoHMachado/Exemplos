
using RabbitMQ.Client;
namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IRabbitMqConnection
    {
         Task<IConnection> GetConnection();
    }
}