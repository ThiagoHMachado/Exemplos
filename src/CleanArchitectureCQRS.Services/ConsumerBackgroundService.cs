using CleanArchitectureCQRS.Application.Consumers;
using CleanArchitectureCQRS.Application.Events;
using CleanArchitectureCQRS.Domain.DTO.Request;
using CleanArchitectureCQRS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
namespace CleanArchitectureCQRS.Services
{
    public class ConsumerBackgroundService
        : BackgroundService
    {
        private readonly BdcleanarchitecturecqrsMdfContext context;
        private readonly RabbitMqConsumer<RabbitMqConsumer<BaseEventCommand<ClienteRequest>.CriarCommand>> rabbitMqClientConsumer;

        public ConsumerBackgroundService(RabbitMqConsumer<RabbitMqConsumer<BaseEventCommand<ClienteRequest>.CriarCommand>> rabbitMqClientConsumer)
        {
            this.context = context;
            this.rabbitMqClientConsumer = rabbitMqClientConsumer;
        }

        protected override Task ExecuteAsync(
            CancellationToken stoppingToken)
        {




            ;

            rabbitMqClientConsumer.Consume(routingKey: "order.created");


            return Task.CompletedTask;
        }
    }
}
