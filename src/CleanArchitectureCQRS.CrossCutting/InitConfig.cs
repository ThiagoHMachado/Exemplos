

using AutoMapper;
using CleanArchitectureCQRS.Application;
using CleanArchitectureCQRS.Application.Commands.Validator;
using CleanArchitectureCQRS.Application.Consumers;
using CleanArchitectureCQRS.Application.Events;
using CleanArchitectureCQRS.Application.Events.Create;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.DTO.Request;
using CleanArchitectureCQRS.Infrastructure;
using CleanArchitectureCQRS.Infrastructure.Persistence;
using CleanArchitectureCQRS.Services;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArchitectureCQRS.CrossCutting
{
    public static class InitConfig
    {
        public static void AddCache(this IServiceCollection services)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "localhost:6379"; // Your Redis connection string                
            });

        }
        public static void AddService(this IServiceCollection services)
        {

            //  services.AddValidatorsFromAssemblyContaining(typeof(ClienteValidator));

            services.AddScoped<IRedisService, RedisService>();
            services.AddScoped<IRabbitService, RabbitService>();
            services.AddScoped(typeof(ICleanArchitectureCQRSRepository<>), typeof(CleanArchitectureCQRSRepository<>));

            //  services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        }
        public static IServiceCollection AddMessaging(
        this IServiceCollection services)
        {
            services.AddSingleton<
               IRabbitMqConnection,
               RabbitMqConnection>();

            services.AddSingleton(
                typeof(RabbitMqConsumer<>));

            services.AddScoped<
                IEventHandler<OrderCreatedEvent>,
                OrderCreatedHandler>();

            services.AddScoped<
                IEventHandler<BaseEventCommand<>.CriarCommand>,
               BaseEventCommand<>.CriarCommand>();

            services.AddHostedService<
                ConsumerBackgroundService>();

            return services;
        }
        public static void AddContext(this IServiceCollection services, string conn)
        {

            // Registra o DbContext
            services.AddDbContext<BdcleanarchitecturecqrsMdfContext>(options =>
            {
                options.UseSqlServer(conn);


            });

        }
    }
}
