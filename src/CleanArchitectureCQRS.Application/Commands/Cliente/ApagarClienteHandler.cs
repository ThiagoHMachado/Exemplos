using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarClienteHandler : IRequestHandler<ApagarClienteCommand>
{
    private readonly ICleanArchitectureCQRSRepository<Cliente> _repo;
    private readonly IMapper mapper;
    private readonly IRabbitService rabbitService;
    const string routeKey = "CleanArchitectureCQRS.eventsourcing.cliente.delete";
    public ApagarClienteHandler(ICleanArchitectureCQRSRepository<Cliente> repo, IMapper mapper, IRabbitService rabbitService)
    {
        _repo = repo;
        this.mapper = mapper;
        this.rabbitService = rabbitService;
    }

    public async Task Handle(ApagarClienteCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Cliente>(request.entity);
        await rabbitService.PublishAsync<Cliente>(routeKey, entity);
        _repo.DeleteAsync(entity);

    }
}