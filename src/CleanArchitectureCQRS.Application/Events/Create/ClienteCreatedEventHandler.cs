using AutoMapper;
using CleanArchitectureCQRS.Application.Commands;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.DTO.Request;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using static CleanArchitectureCQRS.Application.Events.BaseEventCommand<CleanArchitectureCQRS.Domain.DTO.Request.ClienteRequest>.CriarCommand;

namespace CleanArchitectureCQRS.Application.Events.Create
{
    public class CriarClienteEventHandler : IRequestHandler<BaseEventCommand<ClienteRequest>.CriarCommand>
    {
        private readonly IMapper mapper;
        private readonly IRabbitService rabbitService;
        const string routeKey = "cleanArchitectureCQRS.eventsourcing.cliente.create";
        public CriarClienteEventHandler(
                                   IMapper mapper,
                                   IRabbitService rabbitService)
        {

            this.mapper = mapper;
            this.rabbitService = rabbitService;
        }

        public async Task Handle(BaseEventCommand<ClienteRequest>.CriarCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Cliente>(request.entity);
            await rabbitService.PublishAsync<Cliente>(routeKey, entity);
        }
    }
}
