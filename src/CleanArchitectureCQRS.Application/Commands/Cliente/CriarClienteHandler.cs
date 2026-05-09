using MediatR;
using CleanArchitectureCQRS.Application.Interfaces;
using AutoMapper;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Events;
using CleanArchitectureCQRS.Domain.DTO.Request;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarClienteHandler :  IRequestHandler<CriarClienteCommand>
{
    private readonly ICleanArchitectureCQRSRepository<Cliente> _repo;
    private readonly IMapper mapper;
    private readonly IRabbitService rabbitService;
    const string routeKey = "cleanArchitectureCQRS.eventsourcing.cliente.create";
    public CriarClienteHandler(ICleanArchitectureCQRSRepository<Cliente> repo,
                               IMapper mapper,
                               IRabbitService rabbitService)
    {
        _repo = repo;
        this.mapper = mapper;
        this.rabbitService = rabbitService;
    }

    public async Task Handle(CriarClienteCommand request, CancellationToken cancellationToken)
    {

        var entity = mapper.Map<Cliente>(request.entity);
        await rabbitService.PublishAsync<Cliente>(routeKey, entity);
        await _repo.AddAsync(entity);
    }
}