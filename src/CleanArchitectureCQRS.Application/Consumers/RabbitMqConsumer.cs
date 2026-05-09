using CleanArchitectureCQRS.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace CleanArchitectureCQRS.Application.Consumers
{
    public class RabbitMqConsumer<TEvent>
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly IRabbitMqConnection _connection;

        public RabbitMqConsumer(
            IServiceProvider serviceProvider,
            IRabbitMqConnection connection)
        {
            _serviceProvider = serviceProvider;
            _connection = connection;
        }

        public async Task Consume(

            string routingKey)
        {
            var conn = await _connection.GetConnection();
            var channel = await conn.CreateChannelAsync();
            string exchange = "CleanArchitectureCQRS.eventsourcing";
            string queue = routingKey;
            await channel.ExchangeDeclareAsync(
                exchange: exchange,
                type: ExchangeType.Direct,
                durable: true);

            await channel.QueueDeclareAsync(
                queue: queue,
                durable: true,
                exclusive: false,
                autoDelete: false);

            await channel.QueueBindAsync(
                queue: queue,
                exchange: exchange,
                routingKey: routingKey);

            var consumer =
                new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (model, ea) =>
            {
                try
                {
                    var json = Encoding.UTF8.GetString(
                        ea.Body.ToArray());

                    var message =
                        JsonSerializer.Deserialize<TEvent>(json);

                    using var scope =
                        _serviceProvider.CreateAsyncScope();

                    var handler =
                        scope.ServiceProvider
                        .GetRequiredService<IEventHandler<TEvent>>();

                    await handler.HandleAsync(
                        message!,
                        CancellationToken.None);

                    await channel.BasicAckAsync(
                                            ea.DeliveryTag,
                                            false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    await channel.BasicNackAsync(
                           ea.DeliveryTag,
                           false,
                           true);
                }
            };

            await channel.BasicConsumeAsync(
                queue: queue,
                autoAck: false,
                consumer: consumer);

            Console.WriteLine(
                $"Consumer started: {typeof(TEvent).Name}");
        }
    }
}
