using CleanArchitectureCQRS.Application.Interfaces;

using RabbitMQ.Client;
using Microsoft.Extensions.Configuration;


namespace CleanArchitectureCQRS.Application.Consumers
{
    public class RabbitMqConnection : IRabbitMqConnection
    {

        private readonly ConnectionFactory _factory;
        public RabbitMqConnection(IConfiguration configuration)
        {
            var section = configuration.GetSection("RabbitMQ")!;
            _factory = new ConnectionFactory
            {
                HostName = section["HostName"]!,
                UserName = section["UserName"]!,
                Password = section["Password"]!
            };
        }
        public async Task<IConnection> GetConnection()
        {
            return await _factory.CreateConnectionAsync();
        }
    }
}
