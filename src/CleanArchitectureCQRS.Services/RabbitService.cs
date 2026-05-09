using System.Text;
using System.Text.Json;
using CleanArchitectureCQRS.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
namespace CleanArchitectureCQRS.Services
{
    public class RabbitService : IRabbitService
    {

        private readonly IConfiguration configuration;
        private IConfigurationSection
            SettingsRabbit;
        public RabbitService(IConfiguration configuration)
        {
            this.configuration = configuration;
            var section = configuration.GetSection("RabbitMQ");
            SettingsRabbit = section;
        }

        public async Task PublishAsync<T>(
            string routingKey,
            T message)
        {
            try
            {
                var factory = new ConnectionFactory()
                {
                    HostName = SettingsRabbit["HostName"],
                    Port = Convert.ToInt32(SettingsRabbit["Port"]),
                    UserName = SettingsRabbit["UserName"],
                    Password = SettingsRabbit["Password"],
                    VirtualHost = "/",
                    RequestedConnectionTimeout = TimeSpan.FromSeconds(30), // Padrão é baixo
                    SocketReadTimeout = TimeSpan.FromSeconds(30),
                    SocketWriteTimeout = TimeSpan.FromSeconds(30)
                };
                using var connection = await factory.CreateConnectionAsync();
                using var channel = await connection.CreateChannelAsync();

                string exchange = SettingsRabbit["ExchangeName"];

                await channel.ExchangeDeclareAsync(
                     exchange: exchange,
                     type: ExchangeType.Direct,
                     durable: true);

                var json = JsonSerializer.Serialize(message);

                var body = Encoding.UTF8.GetBytes(json);

                await channel.BasicPublishAsync(
                    exchange: exchange,
                    routingKey: routingKey,
                    body: body);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

    }
    public class RabbitSettingsModel
    {

        public string HostName { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ExchangeName { get; set; }

    }
}
